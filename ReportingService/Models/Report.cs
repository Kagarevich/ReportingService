using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string UserLogin { get; set; }
        public User User { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
    }
}
