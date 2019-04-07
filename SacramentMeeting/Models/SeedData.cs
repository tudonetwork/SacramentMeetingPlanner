using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeeting.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingContext>>()))
            {
                // Look for any meetings.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {                       
                        MeetingDate = DateTime.Parse("2019-3-17"),
                        Conducting = "Bruce Willies",
                        Presiding = "Bruce Willies",
                        Invocation = "Mary Jo",
                        Benediction = "Bruce Lee",
                        OpeningHymn = 344,
                        SacramentHymn = 134,
                        ClosingHymn = 235,
                        Speaker1 = "James Rick",
                        Topic1 = "Repenance",
                        Speaker2 = "Betty Jo",
                        Topic2 = "Endure to the end",
                        Speaker3 = "Leslie Brooke",
                        Topic3 = "Prayer"
                    },

                    new Meeting
                    {
                        MeetingDate = DateTime.Parse("2019-2-12"),
                        Conducting = "Bruce Willies",
                        Presiding = "Bruce Willies",
                        Invocation = "Mary Jo",
                        Benediction = "Bruce Lee",
                        OpeningHymn = 344,
                        SacramentHymn = 134,
                        ClosingHymn = 235,
                        Speaker1 = "James Rick",
                        Topic1 = "Repenance",
                        Speaker2 = "Betty Jo",
                        Topic2 = "Endure to the end",
                        Speaker3 = "Leslie Brooke",
                        Topic3 = "Prayer"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

