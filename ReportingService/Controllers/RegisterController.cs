using Microsoft.AspNetCore.Mvc;
using ReportingService.Models;
using ReportingService.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        IWorkerWithUser reg;
        public RegisterController(IWorkerWithUser _reg)
        {
            reg = _reg;
        }
        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            await reg.Post(user);
            return Ok(user);
        }
    }
}
