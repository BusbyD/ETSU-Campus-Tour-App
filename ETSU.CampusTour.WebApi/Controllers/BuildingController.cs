using Azure.Core;
using ETSU.CampusTour.SharedLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;

namespace ETSU.CampusTour.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly BucViewContext _context;

        public BuildingController(BucViewContext context)
        {
            _context = context;
        }

        // GET: api/Building
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Building>>> GetBuildings()
        {
            return await _context.Buildings.ToListAsync();
        }

        // GET: api/Building/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Building>> GetBuilding(int id)
        {
            var building = await _context.Buildings.FindAsync(id);

            if (building == null)
            {
                return NotFound();
            }

            return building;
        }

        // PUT: api/Building/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBuilding(int id, Building building)
        {
            if (id != building.Building_Id)
            {
                return BadRequest();
            }

            _context.Entry(building).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Building
        [HttpPost]
        public async Task<ActionResult<Building>> PostBuilding(Building building)
        {
            _context.Buildings.Add(building);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBuilding", new { id = building.Building_Id }, building);
        }

        // DELETE: api/Building/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Building>> DeleteBuilding(int id)
        {
            var building = await _context.Buildings.FindAsync(id);
            if (building == null)
            {
                return NotFound();
            }

            _context.Buildings.Remove(building);
            await _context.SaveChangesAsync();

            return building;
        }

        private bool BuildingExists(int id)
        {
            return _context.Buildings.Any(e => e.Building_Id == id);
        }
    }




}
