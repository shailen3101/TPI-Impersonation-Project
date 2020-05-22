using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RemoteGamingSystem.Sample.Api.Models
{
    public class FreeSpinDataDetails
    {
        [Required]
        public decimal CostPerBet { get; set; }

        [Required]
        public double ChipSize { get; set; }

        [Required]
        public int NumberOfCoins { get; set; }

        [Required]
        public int NumberOfPaylines { get; set; }
    }
}
