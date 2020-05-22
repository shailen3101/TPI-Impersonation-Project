using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models
{
    public class CancelTransactionDetails
    {
        //Must increase in increments of 1
        public int TransSeq { get; set; } = 1;

        [Required]
        [StringLength(ApplicationConstants.TransactionId)]
        //GUID - ensure that it is unique
        public string TransId { get; set; }

        [Required]
        public decimal TransAmt { get; set; }

        [Required]
        //Decide on enumeration
        public string TransType { get; set; }

        [Required]
        //Decide on enumeration
        //Is the only categories we are using found in the documentation
        public string TransCategory { get; set; }

        [Required]
        [StringLength(255)]
        public string TransDesc { get; set; }
       
        [Required]
        //Explanation of this is not included in Doc
        public string ReferenceId { get; set; }

        [Required]
        //Explanation of this is not included in Doc
        //What type are we going with ?
        public DateTime TransDay { get; set; }

    }
}
