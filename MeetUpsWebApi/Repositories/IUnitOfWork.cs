using MeetUpsWebApi.DataMembers;
using System.Threading.Tasks;

namespace MeetUpsWebApi.Repositories
{
    public interface IUnitOfWork //: IDisposable
    {
        IGenericRepository<MeetUp> MeetUps { get; }
        IGenericRepository<Lesson> Lessons { get; }
        IGenericRepository<Lecturer> Lecturers { get; }

        Task Save();
    }
}
