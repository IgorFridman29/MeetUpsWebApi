using MeetUpsWebApi.DataMembers;
using System;
using System.ComponentModel.DataAnnotations;

namespace MeetUpsWebApi.DTOs
{
    public class CreateLessonDTO
    {
        [Required]
        public string Topic { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        [Required]
        public int MeetUpId { get; set; }

        [Required]
        public int LecturerId { get; set; }
    }

    public class LessonDTO : CreateLessonDTO
    {
        public int Id { get; set; }
        public MeetUpDTO MeetUp { get; set; }
        public LecturerDTO Lecturer { get; set; }
    }
}
