using Microsoft.AspNetCore.Mvc;
using InmueblesApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class InmueblesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public InmueblesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Inmuebles
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Inmueble>>> GetInmuebles()
    {
        return await _context.Inmuebles.ToListAsync();
    }

    // GET: api/Inmuebles/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Inmueble>> GetInmueble(int id)
    {
        var inmueble = await _context.Inmuebles.FindAsync(id);
        if (inmueble == null)
        {
            return NotFound();
        }
        return inmueble;
    }

    // POST: api/Inmuebles
    [HttpPost]
    public async Task<ActionResult<Inmueble>> PostInmueble(Inmueble inmueble)
    {
        _context.Inmuebles.Add(inmueble);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetInmueble), new { id = inmueble.Id }, inmueble);
    }

    // PUT: api/Inmuebles/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutInmueble(int id, Inmueble inmueble)
    {
        if (id != inmueble.Id)
        {
            return BadRequest();
        }
        _context.Entry(inmueble).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!InmuebleExists(id))
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

    // DELETE: api/Inmuebles/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteInmueble(int id)
    {
        var inmueble = await _context.Inmuebles.FindAsync(id);
        if (inmueble == null)
        {
            return NotFound();
        }
        _context.Inmuebles.Remove(inmueble);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    private bool InmuebleExists(int id)
    {
        return _context.Inmuebles.Any(e => e.Id == id);
    }
}