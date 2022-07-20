using MeetUpsWebApi.DataMembers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetUpsWebApi.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class SeedMiddleware
    {
        private readonly RequestDelegate _next;

        public SeedMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, MeetUpDbContext dbContext)
        {
            //if (dbContext.Database.CanConnect() && !dbContext.Roles.Any())
            //{
            //    await insertRollsDataAsync(dbContext);
            //}

            if (dbContext.Database.CanConnect() && !dbContext.Lessons.Any())
            {
                await InsertDataAsync(dbContext);
            }
            await _next(httpContext);
        }

        //private async Task insertRollsDataAsync(MeetUpDbContext dbContext)
        //{
        //    var roles = new List<IdentityRole>
        //    {
        //        new IdentityRole
        //        {
        //            Name = "User",
        //            NormalizedName = "USER"
        //        },
        //        new IdentityRole
        //        {
        //            Name = "Admin",
        //            NormalizedName = "ADMIN"
        //        },
        //        new IdentityRole
        //        {
        //            Name = "Manager",
        //            NormalizedName = "MANAGER"
        //        }
        //    };

        //    await dbContext.AddRangeAsync(roles);
        //    await dbContext.SaveChangesAsync();
        //}

        private async Task InsertDataAsync(MeetUpDbContext dbContext)
        {
            var firstMeetUp = new MeetUp
            {
                Title = "Super MeetUp",
                Address = "Yigal Alon",
                Date = DateTime.Now.AddMonths(1)
            };

            var secondMeetUp = new MeetUp
            {
                Title = "MeetUp",
                Address = "Azrieli",
                Date = DateTime.Now.AddMonths(2)
            };

            var restaurants = new List<Lesson> {

            new Lesson
            {
                Topic = "Super Lesson One",
                Time = DateTime.Now.AddMonths(1).AddHours(10),
                Duration = TimeSpan.FromHours(2),
                Lecturer = new Lecturer
                {
                    Name = "Guy the king",
                    Rank = 5
                },
                MeetUp = firstMeetUp
            },
            new Lesson
            {
                Topic = "Super Lesson Two",
                Time = DateTime.Now.AddMonths(1).AddHours(12),
                Duration = TimeSpan.FromHours(2),
                Lecturer = new Lecturer
                {
                    Name = "Ofir",
                    Rank = 4
                },
                MeetUp = firstMeetUp
            },
            new Lesson
            {
                Topic = "Lesson One",
                Time = DateTime.Now.AddMonths(2).AddHours(10),
                Duration = TimeSpan.FromHours(2),
                Lecturer = new Lecturer
                {
                    Name = "Igor",
                    Rank = 2
                },
                MeetUp = secondMeetUp
            },
            new Lesson
            {
                Topic = "Lesson Two",
                Time = DateTime.Now.AddMonths(2).AddHours(12),
                Duration = TimeSpan.FromHours(2),
                Lecturer = new Lecturer
                {
                    Name = "Lecturer",
                    Rank = 5
                },
                MeetUp = secondMeetUp
            }
        };
            await dbContext.AddRangeAsync(restaurants);
            await dbContext.SaveChangesAsync();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SeedMiddlewareExtensions
    {
        public static IApplicationBuilder UseSeedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedMiddleware>();
        }
    }
}
