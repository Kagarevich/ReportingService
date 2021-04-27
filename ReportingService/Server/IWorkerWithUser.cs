using Microsoft.AspNetCore.Mvc;
using ReportingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Server
{
    public interface IWorkerWithUser
    {
        public Task Post(User user);
    }
}
