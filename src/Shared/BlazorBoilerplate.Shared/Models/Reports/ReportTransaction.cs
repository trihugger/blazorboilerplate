using System;
using System.ComponentModel.DataAnnotations;

namespace PEXHub.Models
{
    public class ReportTransaction
    {
        public int ID { get; set; }

        [Required]
        public int Name { get; set; }

        [Required]
        public StepStatus Status { get; set; }
        [Required]
        public TransactionStatus TransactionStatus { get; set; }

        public int ReportId { get; set; }
        
    }

    public enum TransactionStatus
    {
        PendingReview,
        Reviewe,
        Skipped
    }
}
