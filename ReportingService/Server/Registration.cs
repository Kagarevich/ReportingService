using Microsoft.AspNetCore.Mvc;
using ReportingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Server
{
    public class Registration : IWorkerWithUser
    {
        ApplicationContext db;
        public Registration(ApplicationContext context)
        {
            db = context;
        }
        public async Task Post(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            Console.WriteLine("200");
        }
    }
}
