using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FlightManifest.Models;
using System.Linq;

namespace FlightManifest.Controllers
{
    [Route("api/flight")]
    public class flightController : Controller
    {
    [HttpGet]
    public IEnumerable<flightItem> GetAll(){
        
        return _context.flightItems.ToList();

    }
    [HttpGet("{id}", Name = "Getflight")]
    public IActionResult GetById(long id){
        var item = _context.flightItems.FirstOrDefault(t =>t.Id ==id);
        if (item == null){
            return NotFound();
        }
        return new ObjectResult(item);
    }
        private readonly flightContext _context;
        public flightController(flightContext context)
        {
            _context = context;
            if (_context.flightItems.Count()== 0)
            {
                _context.flightItems.Add(new flightItem{Name = "Trey"});
                _context.SaveChanges();

            }
        }
        
    }
}
