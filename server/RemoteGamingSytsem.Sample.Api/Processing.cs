using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RemoteGamingSystem.Sample.Api.Models;
using Jil;


namespace RemoteGamingSystem.Sample.Api
{
  public class Processing
  {
    public VerifyPlayerSession InitVerifyPlayerSessionSession(string request )
    {
      var verifyPlayerSessionRequest = JSON.Deserialize<VerifyPlayerSession>(request);
      return verifyPlayerSessionRequest;
    }
  }
}
