using Microsoft.AspNetCore.Mvc;
using SmartHomeApi.Models;
using System.Collections.Generic;

namespace SmartHomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private static List<Device> devices = new List<Device>
        {
            new Device { Id = 1, Name = "Light", IsOn = false },
            new Device { Id = 2, Name = "Thermostat", IsOn = true }
        };

        [HttpGet]
        public IEnumerable<Device> Get() => devices;

        [HttpGet("{id}")]
        public ActionResult<Device> Get(int id)
        {
            var device = devices.Find(d => d.Id == id);
            if (device == null)
                return NotFound();
            return device;
        }

    }
}
