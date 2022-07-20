using MeetUpsWebApi.DataMembers;
using System;
using System.Threading.Tasks;

namespace MeetUpsWebApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeetUpDbContext _databaseContext;
        private IGenericRepository<MeetUp> _meetups;
        private IGenericRepository<Lesson> _lessons;
        private IGenericRepository<Lecturer> _lecturers;

        public IGenericRepository<MeetUp> MeetUps => _meetups ??= new GenericRepository<MeetUp>(_databaseContext);

        public IGenericRepository<Lesson> Lessons => _lessons ??= new GenericRepository<Lesson>(_databaseContext);

        public IGenericRepository<Lecturer> Lecturers => _lecturers ??= new GenericRepository<Lecturer>(_databaseContext);

        public UnitOfWork(MeetUpDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        //public void Dispose()
        //{
        //    _databaseContext.Dispose();
        //    GC.SuppressFinalize(this);
        //}

        public async Task Save()
        {
            await _databaseContext.SaveChangesAsync();
        }
    }
}
