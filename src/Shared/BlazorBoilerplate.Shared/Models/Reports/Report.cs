using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PEXHub.Models
{
    public class Report
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public StepStatus Status { get; set; }

        public List<ReportTransaction> Transactions { get; set; }
    }
}
