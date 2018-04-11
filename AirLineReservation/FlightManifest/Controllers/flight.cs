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
       [HttpPost]
        public IActionResult Create([FromBody] flightItem item)
        {
            if (item == null){
                return BadRequest();
            }
            _context.flightItems.Add(item);
            _context.SaveChanges();
            return CreatedAtRoute("Getflight", new { id = item.Id}, item);
        }
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] flightItem item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }
            var flight = _context.flightItems.FirstOrDefault(t => t.Id ==id);
            if (flight == null)
            {
                return NotFound();
            
            }
            flight.IsComplete = item.IsComplete;
            flight.Name = item.Name;
            flight.Seat = item.Seat;

            _context.flightItems.Update(flight);
            _context.SaveChanges();
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var flight = _context.flightItems.FirstOrDefault(t => t.Id == id);
            if (flight == null)
            {
                return NotFound();
            }
            _context.flightItems.Remove(flight);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
