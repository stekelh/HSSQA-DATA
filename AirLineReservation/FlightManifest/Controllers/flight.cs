using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlightManifest.Models;


namespace FlightManifest.Controllers
{
    [Route("api/[controller]")]
    public class flightController : Controller
    {
        [HttpGet]
        public IEnumerable<flightItem> GetAll()
        {

            return _context.flightItems.ToList();

        }
        [HttpGet("{id}", Name = "Getflight")]
        public IActionResult GetById(long id)
        {
            var item = _context.flightItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
        private readonly flightContext _context;
        public flightController(flightContext context)
        {
            _context = context;
            if (_context.flightItems.Count() == 0)
            {
                _context.flightItems.Add(new flightItem { Name = "Trey", Seat = "2A" });
                _context.SaveChanges();
            }
        }

    }
}
