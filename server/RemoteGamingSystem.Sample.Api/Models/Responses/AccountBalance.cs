using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
public class AccountBalance
{
       
    [Required]
    [StringLength(ApplicationConstants.PlayerId)]
    public string PlayerId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.AccountId)]
    public string AccountId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.CurrencyCode)]
    public string CurrencyCode { get; set; }

    //[Required]
    //Identify how to represent this
    //public IEnumerable<Message> messageArray { get; set; }

    [Required]
    public decimal AvailBalanceAmt { get; set; }

    public bool AvailFreeSpins { get; set; }

    [Required]
    public IEnumerable<BalanceArray> BalanceArray { get; set; }
}
}

