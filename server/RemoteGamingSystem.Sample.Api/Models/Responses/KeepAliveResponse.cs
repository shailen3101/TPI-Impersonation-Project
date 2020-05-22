using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
public class KeepAliveResponse
{
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
}
}
