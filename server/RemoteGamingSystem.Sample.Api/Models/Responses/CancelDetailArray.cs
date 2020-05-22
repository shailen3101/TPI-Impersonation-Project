using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;


namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
    public class CancelDetailArray
    {
        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public BalanceTypes? BalanceType { get; set; }

        public long? BalanceSeq { get; set; }

        [Required]
        public decimal DetailAmt { get; set; }

        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public TransTypes? DetailType { get; set; }

        [Required]
        public decimal BalanceAmt { get; set; }
    }
}
