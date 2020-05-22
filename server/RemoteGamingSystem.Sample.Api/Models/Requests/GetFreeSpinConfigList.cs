using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models
{
    public class GetFreeSpinConfigList
    {
        [Required]
        [StringLength(ApplicationConstants.UniqueId)]
        public string GameId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.BrandId)]
        public string BrandId { get; set; }

        [Required]
        [StringLength(ApplicationConstants.SkinId)]
        public string SkinId { get; set; }

        [Required] //Check
        public bool IncludeAllStates { get; set; }
    }
}
