using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RemoteGamingSystem.Sample.Api.Models;

namespace RemoteGamingSystem.Sample.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RgsController : ControllerBase
  {
    // GET: api/RGS
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET: api/RGS/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/RGS
    [HttpPost]
    public VerifyPlayerSession Post([FromBody] VerifyPlayerSession request)
    {
      var hello = 0; 
      return request;
    }

    // PUT: api/RGS/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
