using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using GameOn.ModelClasses;

namespace GameOn.DataLayer.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<GameOnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "GameOn";
        }

        protected override void Seed(GameOnContext context)
        {
            var Event = new Event
            {
                Description = "test event 1",
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                Location = "test loc"
            };
            var sport = new Sport
            {
                Location = "test loc",
                Name = "Sprot 1",
                UserInformationId = 1
            };
            var userInfo = new UserInformation
            {
                UserId = 1,
                Sports = new List<Sport> { sport }
            };

            var user = new List<User>{
            new User
                {
                    FirstName="Domhnall",
                LastName ="Oneill",
                DateOfBirth =new DateTime(2008,1,28),
                Email = "doneill@mywebgrocer.com",
                Events = new List<Event>{Event},
                UserInformations = new List<UserInformation> { userInfo }
                }
            };
            context.Users.AddOrUpdate(user.ToArray());
        }
    }
}
