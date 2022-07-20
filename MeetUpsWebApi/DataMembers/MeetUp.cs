using System;
using System.Collections.Generic;

namespace MeetUpsWebApi.DataMembers
{
    public class MeetUp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
