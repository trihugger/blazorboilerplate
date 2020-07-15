using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PEXHub.Models
{
    public class ReportConfig
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Transaction Identifier")]
        public string TransactionID { get; set; }

        public List<Step> Steps { get; set; }

        [DisplayName("Min. Review Percentage")]
        [Range(1, 100,ErrorMessage = "Number must be from 1 to 100")]
        public int ReviewPercentage { get; set; }

        public List<Auth> Auths { get; set; }

    }
}
