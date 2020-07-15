using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PEXHub.Models
{
    public class Step
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public int ReportId { get; set; }
    }
}
