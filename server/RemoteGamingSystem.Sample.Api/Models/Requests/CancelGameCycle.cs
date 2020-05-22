using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models
{
public class CancelGameCycle
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
    [StringLength(ApplicationConstants.GameSessionId)]
    public string GameSessionId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.CurrencyCode)]
    public string CurrencyCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.BrandId)]
    public string BrandId { get; set; }
    [Required]
    [StringLength(ApplicationConstants.SkinId)]
    public string SkinId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.LocaleCode)]
    public string LocaleCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.GameCycleId)]
    //Use GUID - this needs to be unique for this particular RGS
    public string GameCycleId { get; set; }

    //Decide whether we are using enumeration or not
    //Check each of the cases
    public int GameCycleExc { get; set; } = 1;

    [Required]
    [StringLength(ApplicationConstants.GameGroupId)]
    //Refer to documentation
    public string GameGroupId { get; set; }
}
}
