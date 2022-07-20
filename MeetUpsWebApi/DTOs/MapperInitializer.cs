using AutoMapper;
using MeetUpsWebApi.DataMembers;

namespace MeetUpsWebApi.DTOs
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            // Map MeetUp
            CreateMap<MeetUp,       MeetUpDTO>().ReverseMap();
            CreateMap<MeetUp, CreateMeetUpDTO>().ReverseMap();

            // Map Lesson
            CreateMap<Lesson,       LessonDTO>().ReverseMap();
            CreateMap<Lesson, CreateLessonDTO>().ReverseMap();

            // Map Lecturer
            CreateMap<Lecturer,       LecturerDTO>().ReverseMap();
            CreateMap<Lecturer, CreateLecturerDTO>().ReverseMap();
        }
    }
}
