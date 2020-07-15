using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PEXHub.Models
{
    public class Auth
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Department { get; set; }
        public string SecurityGroup { get; set; }

        public int ReportId { get; set; }
    }
}
