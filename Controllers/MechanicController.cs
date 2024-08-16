using AR_VehicleServiceCenter.Data;
using AR_VehicleServiceCenter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AR_VehicleServiceCenter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MechanicController : ControllerBase
    {
        private readonly VehicleServiceContext _context;

        public MechanicController(VehicleServiceContext context)
        {
            _context = context;
        }

        // GET: api/Mechanic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mechanic>>> GetMechanics()
        {
            return await _context.Mechanics.ToListAsync();
        }

        // GET: api/Mechanic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mechanic>> GetMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FindAsync(id);

            if (mechanic == null)
            {
                return NotFound();
            }

            return mechanic;
        }

        // POST: api/Mechanic
        [HttpPost]
        public async Task<ActionResult<Mechanic>> PostMechanic(Mechanic mechanic)
        {
            _context.Mechanics.Add(mechanic);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMechanic), new { id = mechanic.MechanicId }, mechanic);
        }

        // PUT: api/Mechanic/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMechanic(int id, Mechanic mechanic)
        {
            if (id != mechanic.MechanicId)
            {
                return BadRequest();
            }

            _context.Entry(mechanic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MechanicExists(id))
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

        // DELETE: api/Mechanic/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FindAsync(id);
            if (mechanic == null)
            {
                return NotFound();
            }

            _context.Mechanics.Remove(mechanic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MechanicExists(int id)
        {
            return _context.Mechanics.Any(e => e.MechanicId == id);
        }
    }
}
