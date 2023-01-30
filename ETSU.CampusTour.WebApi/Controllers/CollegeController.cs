using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETSU.CampusTour.SharedLibrary.Models;

namespace ETSU.CampusTour.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly BucViewContext _context;

        public CollegeController(BucViewContext context)
        {
            _context = context;
        }

        private bool CollegeExists(int id)
        {
            return _context.College.Any(e => e.College_Id == id);
        }

        // GET: api/College
        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetCollege()
        {
            return await _context.College.ToListAsync();
        }

        // GET: api/College/5
        [HttpGet("{id}")]
        public async Task<ActionResult<College>> GetCollege(int id)
        {
            var college = await _context.College.FindAsync(id);

            if (college == null)
            {
                return NotFound();
            }

            return college;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege(int id, College college)
        {
            if (id != college.College_Id)
            {
                return BadRequest();
            }
            _context.Entry(college).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
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

        // POST: api/College
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<College>> PostCollege(College college)
        {
            _context.College.Add(college);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCollege", new { id = college.College_Id }, college);
        }
    }
}
