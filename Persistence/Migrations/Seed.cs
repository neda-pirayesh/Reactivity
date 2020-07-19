
using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence.Migrations
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
               {
                var activities=new List<Activity>
                {
                    

                            new Activity
                            {
                                Title = "Past Activity 1",
                                Date = DateTime.Now.AddMonths(-2),
                                Description = "Activity 2 months ago",
                                Category = "drinks",
                                City = "London",
                                PropertyName = "Pub",
                            },
                            new Activity
                            {
                                Title = "Past Activity 2",
                                Date = DateTime.Now.AddMonths(-1),
                                Description = "Activity 1 month ago",
                                Category = "culture",
                                City = "Paris",
                                PropertyName = "Louvre",
                            },
                            new Activity
                            {
                                Title = "Future Activity 1",
                                Date = DateTime.Now.AddMonths(1),
                                Description = "Activity 1 month in future",
                                Category = "culture",
                                City = "London",
                                PropertyName = "Natural History Museum",
                            },
                            new Activity
                            {
                                Title = "Future Activity 2",
                                Date = DateTime.Now.AddMonths(2),
                                Description = "Activity 2 months in future",
                                Category = "music",
                                City = "London",
                                PropertyName = "O2 Arena",
                            },
                            new Activity
                            {
                                Title = "Future Activity 3",
                                Date = DateTime.Now.AddMonths(3),
                                Description = "Activity 3 months in future",
                                Category = "drinks",
                                City = "London",
                                PropertyName = "Another pub",
                            },
                            new Activity
                            {
                                Title = "Future Activity 4",
                                Date = DateTime.Now.AddMonths(4),
                                Description = "Activity 4 months in future",
                                Category = "drinks",
                                City = "London",
                                PropertyName = "Yet another pub",
                            },
                            new Activity
                            {
                                Title = "Future Activity 5",
                                Date = DateTime.Now.AddMonths(5),
                                Description = "Activity 5 months in future",
                                Category = "drinks",
                                City = "London",
                                PropertyName = "Just another pub",
                            },
                            new Activity
                            {
                                Title = "Future Activity 6",
                                Date = DateTime.Now.AddMonths(6),
                                Description = "Activity 6 months in future",
                                Category = "music",
                                City = "London",
                                PropertyName = "Roundhouse Camden",
                            },
                            new Activity
                            {
                                Title = "Future Activity 7",
                                Date = DateTime.Now.AddMonths(7),
                                Description = "Activity 2 months ago",
                                Category = "travel",
                                City = "London",
                                PropertyName = "Somewhere on the Thames",
                            },
                            new Activity
                            {
                                Title = "Future Activity 8",
                                Date = DateTime.Now.AddMonths(8),
                                Description = "Activity 8 months in future",
                                Category = "film",
                                City = "London",
                                PropertyName = "Cinema",
                            }
                        };
                        context.Activities.AddRange(activities);
                        context.SaveChanges();
           }

        }
    }
}