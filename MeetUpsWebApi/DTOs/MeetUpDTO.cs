using MeetUpsWebApi.DataMembers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeetUpsWebApi.DTOs
{
    public class CreateMeetUpDTO
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public List<LessonDTO> Lessons { get; set; }

    }

    public class MeetUpDTO : CreateMeetUpDTO
    {
        public int Id { get; set; }
    }
}
