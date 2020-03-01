using System;
using WheelsAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WheelsAPI.Data;

namespace WheelsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {

        private WheelsDBContext _wheelsDbContext;

        public VehiclesController(WheelsDBContext wheelsDBContext)
        {
            _wheelsDbContext = wheelsDBContext;
        }

        // GET: api/Vehicles
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _wheelsDbContext.Vehicles;
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vehicles
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Vehicles/5
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
