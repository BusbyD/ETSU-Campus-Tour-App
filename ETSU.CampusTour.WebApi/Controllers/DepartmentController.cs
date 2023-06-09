﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ETSU.CampusTour.SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly BucViewContext _context;

    public DepartmentController(BucViewContext context)
    {
        _context = context;
    }

    // GET: api/Department
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
    {
        return await _context.Department.ToListAsync();
    }

    // GET: api/Department/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Department>> GetDepartment(int id)
    {
        var department = await _context.Department.FindAsync(id);

        if (department == null)
        {
            return NotFound();
        }

        return department;
    }

    // PUT: api/Department/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutDepartment(int id, Department department)
    {
        if (id != department.Department_Id)
        {
            return BadRequest();
        }

        _context.Entry(department).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!DepartmentExists(id))
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

    // POST: api/Department
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for
    // more details see https://aka.ms/RazorPagesCRUD.
    [HttpPost]
    public async Task<ActionResult<Department>> PostDepartment(Department department)
    {
        _context.Department.Add(department);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetDepartment", new { id = department.Department_Id }, department);
    }

    // DELETE: api/Department/5
    [HttpDelete("{id}")]
    public async Task<ActionResult<Department>> DeleteDepartment(int id)
    {
        var department = await _context.Department.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        _context.Department.Remove(department);
        await _context.SaveChangesAsync();

        return department;
    }

    private bool DepartmentExists(int id)
    {
        return _context.Department.Any(e => e.Department_Id == id);
    }
}
