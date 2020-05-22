using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
public class BalanceArray
{
      
    //[Required]
    //[JsonConverter(typeof(StringEnumConverter))]
    ////What are the different balance types
    //public BalanceTypes? BalanceType { get; set; }

    [Required]
    public decimal BalanceAmt { get; set; }

    //[JsonConverter(typeof(StringEnumConverter))]
    //What are the different balance statuses
    //public BalanceStatuses? BalanceStatus { get; set; }

    [StringLength(ApplicationConstants.TextMessage)]
    public string BalanceRestrict { get; set; }

    public bool FreeSpins { get; set; }

   [StringLength(ApplicationConstants.FreeSpinId)]
    public string FreeSpinId { get; set; }

    public long FreeSpinCnt { get; set; }

    public decimal? FreeSpinValue { get; set; }
}
}

