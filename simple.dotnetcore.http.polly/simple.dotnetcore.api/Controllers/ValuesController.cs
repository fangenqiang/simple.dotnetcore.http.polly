using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simple.dotnetcore.api.HttpClientFactory;
using simple.dotnetcore.http.Priority;

namespace simple.dotnetcore.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHttpClientService _HttpClientService;
        public ValuesController(IHttpClientService httpClientService)
        {
            _HttpClientService = httpClientService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
           var obj=await _HttpClientService.PostAsJsonAsync<object>(HttpClientPriority.BaiduNormal, "/static/index/plus/plus_logo.png", "");
            return new string[] { obj.ToString() };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
