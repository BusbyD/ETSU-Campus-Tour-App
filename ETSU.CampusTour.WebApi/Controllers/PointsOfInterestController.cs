using ETSU.CampusTour.SharedLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class PointsOfInterestController : ControllerBase
{
    private readonly BucViewContext _context;

    public PointsOfInterestController(BucViewContext context)
    {
        _context = context;
    }

    // GET: api/PointsOfInterest
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PointsOfInterest>>> GetPointsOfInterest()
    {
        return await _context.Points_Of_Interest.ToListAsync();
    }

    // GET: api/PointsOfInterest/5
    [HttpGet("{id}")]
    public async Task<ActionResult<PointsOfInterest>> GetPointsOfInterest(int id)
    {
        var pointsOfInterest = await _context.Points_Of_Interest.FindAsync(id);

        if (pointsOfInterest == null)
        {
            return NotFound();
        }

        return pointsOfInterest;
    }

    // PUT: api/PointsOfInterest/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPointsOfInterest(int id, PointsOfInterest pointsOfInterest)
    {
        if (id != pointsOfInterest.Poi_Id)
        {
            return BadRequest();
        }

        _context.Entry(pointsOfInterest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PointsOfInterestExists(id))
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

    // POST: api/PointsOfInterest
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPost]
    public async Task<ActionResult<PointsOfInterest>> PostPointsOfInterest(PointsOfInterest pointsOfInterest)
    {
        _context.Points_Of_Interest.Add(pointsOfInterest);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPointsOfInterest", new { id = pointsOfInterest.Poi_Id }, pointsOfInterest);
    }

    // DELETE: api/PointsOfInterest/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<PointsOfInterest>> DeletePointsOfInterest(int id)
    {
        var pointsOfInterest = await _context.Points_Of_Interest.FindAsync(id);
        if (pointsOfInterest == null)
        {
            return NotFound();
        }

        _context.Points_Of_Interest.Remove(pointsOfInterest);
        await _context.SaveChangesAsync();

        return pointsOfInterest;
    }

    private bool PointsOfInterestExists(int id)
    {
        return _context.Points_Of_Interest.Any(e => e.Poi_Id == id);
    }
}