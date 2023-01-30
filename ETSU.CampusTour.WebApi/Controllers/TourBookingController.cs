using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ETSU.CampusTour.SharedLibrary.Models;

namespace ETSU.CampusTour.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourBookingController : ControllerBase
    {
        private readonly BucViewContext _context;

        public TourBookingController(BucViewContext context)
        {
            _context = context;
        }

        // GET: api/TourBooking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TourBooking>>> GetTourBooking()
        {
            return await _context.Tour_Bookings.ToListAsync();
        }

        // GET: api/TourBooking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TourBooking>> GetTourBooking(int id)
        {
            var tourBooking = await _context.Tour_Bookings.FindAsync(id);

            if (tourBooking == null)
            {
                return NotFound();
            }

            return tourBooking;
        }

        // PUT: api/TourBooking/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTourBooking(int id, TourBooking tourBooking)
        {
            if (id != tourBooking.Booking_Id)
            {
                return BadRequest();
            }

            _context.Entry(tourBooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourBookingExists(id))
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

        // POST: api/TourBooking
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TourBooking>> PostTourBooking(TourBooking tourBooking)
        {
            _context.Tour_Bookings.Add(tourBooking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTourBooking", new { id = tourBooking.Booking_Id }, tourBooking);
        }

        // DELETE: api/TourBooking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourBooking([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tourBooking = await _context.Tour_Bookings.FindAsync(id);
            if (tourBooking == null)
            {
                return NotFound();
            }

            _context.Tour_Bookings.Remove(tourBooking);
            await _context.SaveChangesAsync();

            return Ok(tourBooking);
        }

        private bool TourBookingExists(int id)
        {
            return _context.Tour_Bookings.Any(e => e.Booking_Id == id);
        }

    }
}