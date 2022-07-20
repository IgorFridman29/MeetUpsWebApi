using System;

namespace MeetUpsWebApi.DataMembers
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime Time { get; set; }
        public TimeSpan Duration { get; set; }

        // Foreign key
        public int MeetUpId { get; set; }
        public MeetUp MeetUp { get; set; }

        // Foreign key
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
