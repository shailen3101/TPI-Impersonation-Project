using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models
{
public class VerifyPlayerSession
{
[Required]
[StringLength(ApplicationConstants.BrandId)]
public string BrandId { get; set; }

[Required]
[StringLength(ApplicationConstants.SkinId)]
public string SkinId { get; set; }

[Required]
[StringLength(ApplicationConstants.GameSessionId)]
public string GameId { get; set; } 

[Required]
//Theres 2 types (Desktop/Mobile) How do we handle
public string ChannelType { get; set; }   

[Required]
//remember to validate , this can only be HTML5  - Go through each of the methods to see which properties still apply 
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
