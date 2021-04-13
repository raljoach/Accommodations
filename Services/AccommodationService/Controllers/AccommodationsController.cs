using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccommodationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccommodationsController : ControllerBase
    {
        // GET: <AccommodationsController>/status
        [HttpGet("status")]
        public string Status()
        {
            return "Service is running";
        }

        // GET: <AccommodationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET <AccommodationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST <AccommodationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT <AccommodationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <AccommodationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
