using RemoteGamingSystem.Sample.Api.AppConstants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models
{
    public class EndGameCycle
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

        [Required]
        public decimal TurnoverAmt { get; set; }

        [Required]
        //Clarification on cancel transactions
        public decimal TheoreticalWin { get; set; } = 0;

        [Required]
        public decimal BaseWin { get; set; } = 0;

        [Required]
        public int ProgWin { get; set; } = 0;

        [Required]
        //Should we make all the things that are initialized to 0, nullable
        public decimal BonusWin { get; set; } = 0;

        [Required]
        //Best way to convert to seconds ?
        public DateTime TimePlayed { get; set; }

        [Required]
        //What are sub-games ?
        //What are the limitations for that ?
        public int GamesPlayed { get; set; }
    }
}
