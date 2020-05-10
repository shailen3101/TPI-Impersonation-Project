using RemoteGamingSytem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RemoteGamingSytem.Sample.Api.Models
{
  public class VerifyPlayerSession
  {

    [Required]
    [StringLength(ApplicationConstants.BrandId)]
    public string BrandId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.SkinId)]
    public string SkinId { get; set; }

    [StringLength(ApplicationConstants.GameSessionId)]
    public string GameId { get; set; }

    [Required]
    public string ChannelType { get; set; }

    //remember to validate , this can only be HTML5  - Go through each of the methods to see which properties still apply 
    [Required]
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
  }
}
