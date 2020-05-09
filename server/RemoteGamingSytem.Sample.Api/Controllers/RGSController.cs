using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteGamingSytem.Sample.Api.Models;
using RemoteGamingSytem.Sample.Api.ViewModel;
using Jil;


namespace RemoteGamingSytem.Sample.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class RGSController : ControllerBase
    {
        // GET: api/RGS
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Methods  GetMethodDetails()
        {
            return new Methods()
            {
              StartGameSessionDetails = new StartGameSession(),
              VerifyPlayerSessionDetails = new VerifyPlayerSession()
            };
        }

        // GET: api/RGS/5
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RGS
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public VerifyPlayerSession VerifyPlayerSessionRequest([Microsoft.AspNetCore.Mvc.FromBody] string request)
        {
          var p = new Processing();
          return p.InitVerifyPlayerSessionSession(request);
        }

        // PUT: api/RGS/5
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public void Put(int id, [Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
