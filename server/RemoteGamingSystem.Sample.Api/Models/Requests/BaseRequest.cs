using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.AppConstants;

namespace RemoteGamingSystem.Sample.Api.Models
{
  public class BaseRequest
  {

    [StringLength(ApplicationConstants.RgsId)]
    public string RgsId { get; set; }
   
    [StringLength(ApplicationConstants.PjsId)]
    public string PjsId { get; set; }

    [StringLength(ApplicationConstants.IgpId)]
    public string IgpId { get; set; }
    
    public string RequestId { get; set; }

    [Required]
    [StringLength(ApplicationConstants.Command)]
    public string Command { get; set; }

    [Required]
    public dynamic Data { get; set; }
  }
}
