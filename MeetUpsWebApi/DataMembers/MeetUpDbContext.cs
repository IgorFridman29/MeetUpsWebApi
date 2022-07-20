using Microsoft.EntityFrameworkCore;

namespace MeetUpsWebApi.DataMembers
{
    public class MeetUpDbContext : DbContext
    {
        public DbSet<LecturerDTO> Lecturers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<MeetUp> MeetUps { get; set; }

        public MeetUpDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
