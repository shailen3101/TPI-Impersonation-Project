using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models
{
    public class GetPlayerBalance
    {
        [Required]
        [StringLength(ApplicationConstants.SecureToken)]
        public string SecureToken { get; set; }

        [Required]
        [StringLength(ApplicationConstants.PlayerId)]
        public string PlayerId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.AccountId)]
        public string AccountId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.BrandId)]
        public string BrandId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.SkinId)]
        public string SkinId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.LocaleCode)]
        public string LocaleCode { get; set; }

       

    }
}
