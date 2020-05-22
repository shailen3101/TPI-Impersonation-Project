using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;


namespace RemoteGamingSystem.Sample.Api.Models
{
    public class CreateFreeSpinConfig
    {
        [Required]
        [StringLength(ApplicationConstants.UniqueId)]
        public string GameId { get; set; }

        [Required]
        public string FreeSpinTitle { get; set; }

        [Required]
        public string FreeSpinDesc{ get; set; }

        [Required]
        [StringLength(ApplicationConstants.BrandId)]
        public string BrandId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.SkinId)]
        public string SkinId { get; set; }

        [Required]
        public string PaytableId { get; set; }

        [Required]
        //Check
        //List ?
        public string BaseCurrency { get; set; }

        [Required]
        //check
        public IEnumerable<FreeSpinDataDetails> FreeSpinDataDetails { get; set; }


    }
}
