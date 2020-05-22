using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
    public class FreeSpinConfigArray
    {
        [Required]
        [StringLength(ApplicationConstants.FreeSpinId)]
        public string FreeSpinId { get; set; }

        [Required]
        public string FreeSpinStatus { get; set; }

        [Required]
        public DateTime FreeSpinDateTime { get; set; }

        [Required]
        [StringLength(ApplicationConstants.FreeSpinTitle)]
        public string FreeSpinTitle { get; set; }

        [Required]
        public string FreeSpinDesc { get; set; }

        [Required]
        [StringLength(ApplicationConstants.BrandId)]
        public string BrandId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.SkinId)]
        public string SkinId { get; set; }

        [Required]
        public string PaytableId { get; set; }

        [Required]
        public string BaseCurrency { get; set; }

        [Required]
        public decimal BaseFreeSpinValue { get; set; }
        [Required]
        //Check
        public IEnumerable<FreeSpinDataDetails> FreeSpinDataDetails { get; set; }

    }
}
