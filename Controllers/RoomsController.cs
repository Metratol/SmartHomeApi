using Microsoft.AspNetCore.Mvc;
using SmartHomeApi.Models;
using System.Collections.Generic;

namespace SmartHomeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private static List<Room> rooms = new List<Room>
        {
            new Room { Id = 1, Name = "Living Room", Devices = new List<Device>() },
            new Room { Id = 2, Name = "Bedroom", Devices = new List<Device>() }
        };

        [HttpGet]
        public IEnumerable<Room> Get() => rooms;

        [HttpGet("{id}")]
        public ActionResult<Room> Get(int id)
        {
            var room = rooms.Find(r => r.Id == id);
            if (room == null)
                return NotFound();
            return room;
        }


    }
}
