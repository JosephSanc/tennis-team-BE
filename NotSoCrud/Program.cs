using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotSoCrud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var context = new TeamContext())
            //{
            //    var headCoach = new Staff()
            //    {
            //        FirstName = "Michael",
            //        LastName = "Foreman",
            //        Position = "Head Coach",
            //        EmailAddress = "Foreman@aol.com"
            //    };
            //    var assistantCoach = new Staff()
            //    {
            //        FirstName = "Andrew",
            //        LastName = "Garfield",
            //        Position = "Assistant Coach",
            //        EmailAddress = "Garfield@aol.com"
            //    };
            //    var aPlayer = new Player()
            //    {
            //        FirstName = "Joseph",
            //        LastName = "Sanchez",
            //        EmailAddress = "something",
            //        PhoneNumber = "8888888"
            //    };


            //    context.Players.Add(aPlayer);
            //    context.Staff_Members.Add(headCoach);
            //    context.Staff_Members.Add(assistantCoach);

            //    context.SaveChanges();
            //}



            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
