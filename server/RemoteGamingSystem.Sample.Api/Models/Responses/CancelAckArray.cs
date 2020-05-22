using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models.Responses
{
    public class CancelAckArray
    {
        [Required]
        public int? TransSeq { get; set; }

        [Required]
        [StringLength(ApplicationConstants.TransactionId)]
        public string TransId { get; set; }

        [Required]
        public decimal TransAmt { get; set; }

        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public TransTypes? TransType { get; set; }

        //[Required]
        //[JsonConverter(typeof(StringEnumConverter))]
        //public TransCategoriesTypes? TransCategory { get; set; }

        [StringLength(ApplicationConstants.FreeSpinId)]
        public string FreeSpinId { get; set; }

        [StringLength(ApplicationConstants.PjsId)]
        public string PjsId { get; set; }

        [StringLength(ApplicationConstants.ControllerId)]
        public string ControllerId { get; set; }

        public long LevelId { get; set; }

        public string PjsDay { get; set; }

        [StringLength(ApplicationConstants.TextMessage)]
        public string TransDesc { get; set; }

        [Required]
        [StringLength(ApplicationConstants.ReferenceId)]
        public string ReferenceId { get; set; }

        [Required]
        public string TransDay { get; set; }

        [Required]
        public string CancelId { get; set; }

        [Required]
        public string CancelDay { get; set; }

        [Required]
        public IEnumerable<CancelDetailArray> CancelDetailArray { get; set; }
    }
}
