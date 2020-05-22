using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
    public class GameSessionAckResponse
    {
        [Required]
        [StringLength(ApplicationConstants.SecureToken)]
        public string SecureToken { get; set; }


        [Required]
        [StringLength(ApplicationConstants.GameSessionId)]
        public string GameSessionId { get; set; }


        [Required]
        public AccountBalance AccountBalance { get; set; }
    }
}

