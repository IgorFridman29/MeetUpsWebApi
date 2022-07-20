using AutoMapper;
using MeetUpsWebApi.DTOs;
using MeetUpsWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetUpsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetUpController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MeetUpController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetMeetUps()
        {
            try
            {
                var meetUps = await _unitOfWork.MeetUps.GetAll(include: q => q.Include(mu => mu.Lessons));
                var mappedMeetUps = _mapper.Map<IList<MeetUpDTO>>(meetUps);

                return Ok(mappedMeetUps);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
