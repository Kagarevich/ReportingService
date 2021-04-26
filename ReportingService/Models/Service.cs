using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportingService.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string ProviderName { get; set; }
        public int Sum { get; set; }
        public int ReportId { get; set; }
        public Report Report { get; set; }
        public Provider Provider { get; set; }
    }
}
