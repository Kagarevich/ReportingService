using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Models
{
    public class Provider
    {
        [Key]
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
    }
}
