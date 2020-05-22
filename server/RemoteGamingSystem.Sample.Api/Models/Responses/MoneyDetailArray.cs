using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
    public class MoneyDetailArray
    {
        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        ////Decide on enumeration for this
        //public BalanceTypes? BalanceType { get; set; }

        public long? BalanceSeq { get; set; }

        [Required]
        public decimal DetailAmt { get; set; }

        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        ////Decide on enumeration for this
        //public TransTypes? DetailType { get; set; }

        [Required]
        public decimal BalanceAmt { get; set; }
    }
}
