using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.Models;

namespace RemoteGamingSystem.Sample.Api.Api
{
  public class TpiApiCommunications
  {
    public TpiApiCommunications(BaseRequest request)
    {
      Request = request;
    }

    public BaseRequest Request { get; set; }

    /// <summary>
    /// Sends Request to the TPI API.
    /// </summary>
    /// <returns>Returns the response from the API</returns>
    public BaseRequest SendRequest()
    {
      //Insert logic for tpi call here 
      return Request;
    }
  }
}
