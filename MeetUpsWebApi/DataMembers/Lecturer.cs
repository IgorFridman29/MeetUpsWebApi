namespace MeetUpsWebApi.DataMembers
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public Lesson Lesson { get; set; }
    }
}
