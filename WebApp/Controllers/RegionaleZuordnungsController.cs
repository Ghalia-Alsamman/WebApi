using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionaleZuordnungsController : ControllerBase
    {
        private readonly JS_TestContext _context;
        public RegionaleZuordnungsController()
        {
            _context = new JS_TestContext();
        }

        [HttpGet]
        public IEnumerable<RegionaleZuordnung> Get()
        {           
            IEnumerable<RegionaleZuordnung> rz = _context.RegionaleZuordnungs;
            return rz;
        }

        [HttpGet("{id}")]
        public IActionResult Get (int id)
        {
          RegionaleZuordnung rz = _context.RegionaleZuordnungs.SingleOrDefault(r=>r.Id==id);
            if (rz ==null)
            {
                return NotFound();
            }
            return Ok(rz);
        }

        [HttpPost]
        public IActionResult Post(RegionaleZuordnung rz)
        {
            _context.RegionaleZuordnungs.Add(rz);
            _context.SaveChanges();
            return CreatedAtAction("Get", rz);
        }

        [HttpPut]
        public IActionResult Put(RegionaleZuordnung reg)
        {
            RegionaleZuordnung rz = _context.RegionaleZuordnungs.SingleOrDefault(r => r.Id == reg.Id);
            if(rz == null)
            {
                return NotFound();
            }
            rz.Name = reg.Name;
            rz.Aktiv = reg.Aktiv;
            _context.SaveChanges();
            return Ok("Updated Successfully");
        }

        [HttpPatch]
        public IActionResult Patch(RegionaleZuordnung reg)
        {
            RegionaleZuordnung rz = _context.RegionaleZuordnungs.SingleOrDefault(r => r.Id == reg.Id);
            if (rz == null)
            {
                return NotFound();
            }
            rz.Name = reg.Name;
            _context.SaveChanges();
            return Ok("Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            RegionaleZuordnung rz = _context.RegionaleZuordnungs.SingleOrDefault(r => r.Id == id);
            if (rz == null)
                return NotFound();
            
            rz.Aktiv = false;
            _context.SaveChanges();
            return Ok("Deleted Successfully");
        }
    }
}
