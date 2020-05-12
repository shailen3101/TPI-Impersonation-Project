using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models
{
  public class StartGameSession
  {

    [Required]
    [StringLength(ApplicationConstants.BrandId)]
    public string BrandId { get; set; }
    
    [Required]
    [StringLength(ApplicationConstants.SkinId)]
    public string SkinId { get; set; }
    
    [StringLength(ApplicationConstants.UniqueId)]
    public string GameId { get; set; }

    [Required]// check 
    public string ChannelType { get; set; }

    [Required]// check
    public string PresentType { get; set; }

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
    [StringLength(ApplicationConstants.LocaleCode)]
    public string LocaleCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.CurrencyCode)]
    public string CurrencyCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.GameSessionId)]
    public string GameSessionId { get; set; }

    [Required]// check 
    public string GameType { get; set; }

    [Required]
    [StringLength(ApplicationConstants.MfgCode)]
    public string MfgCode { get; set; }

    [Required]
    [StringLength(ApplicationConstants.UniqueId)]
    public string ThemeId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.UniqueId)]
    public string PaytableId { get; set; }

    [StringLength(ApplicationConstants.ReleaseNumber)]
    public string ReleaseNum { get; set; }

    [Required]
    [StringLength(ApplicationConstants.BetConfigId)]
    public string BetConfigId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.JurisdictionCode)]
    public string JurisdictionCode { get; set; }
  }
}

