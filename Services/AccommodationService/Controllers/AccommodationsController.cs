using AccommodationService.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AccommodationService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccommodationsController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccommodationsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: <AccommodationsController>/status
        [HttpGet("status")]
        public string Status()
        {
            return "Service is running";
        }

        // GET: <AccommodationsController>
        [HttpGet]
        public IEnumerable<AirbnbListing> Get()
        {
            
            List<AirbnbListing> listings = new List<AirbnbListing>();
            var dir = Path.Combine(_webHostEnvironment.ContentRootPath, "Json");
            foreach(var file in Directory.GetFiles(dir))
            {
                var content = System.IO.File.ReadAllText(file);
                listings.AddRange(JsonConvert.DeserializeObject<List<AirbnbListing>>(content));
            }
            return listings;
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
