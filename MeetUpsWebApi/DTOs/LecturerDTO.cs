using MeetUpsWebApi.DTOs;
using System.ComponentModel.DataAnnotations;

namespace MeetUpsWebApi.DataMembers
{
    public class CreateLecturerDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int Rank { get; set; }

        public LessonDTO Lesson { get; set; }
    }

    public class LecturerDTO : CreateLecturerDTO
    {
        public int Id { get; set; }
    }
}
