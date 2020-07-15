using System;
using System.ComponentModel.DataAnnotations;

namespace PEXHub.Models
{
    public class ReportStep
    {
        public int ID { get; set; }

        [Required]
        public int Step { get; set; }

        [Required]
        public StepStatus Status { get; set; }

        public int ReportId { get; set; }
        public Report Report { get; set; }
    }

    public enum StepStatus
    {
        Pending,
        Failed,
        NA,
        Complete
    }
}
