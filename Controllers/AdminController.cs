using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AR_VehicleServiceCenter.Models;
using Microsoft.EntityFrameworkCore;
using AR_VehicleServiceCenter.Data;

namespace AR_VehicleServiceCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly VehicleServiceContext _context;

        public AdminController(VehicleServiceContext context)
        {
            _context = context;
        }

        // GET: api/Admin
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Admin>>> GetAdmins()
        {
            return await _context.Admins.ToListAsync();
        }

        // GET: api/Admin/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Admin>> GetAdmin(int id)
        {
            var admin = await _context.Admins.FindAsync(id);

            if (admin == null)
            {
                return NotFound();
            }

            return Ok(admin);
        }

        // POST: api/Admin
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Admin>> PostAdmin([FromBody] AR_VehicleServiceCenter.DTO.AdminDTO admin)
        {
            if (admin == null)
            {
                return BadRequest("Admin object is null");
            }

            var ob = new Admin { Email = admin.Email, Password = admin.Password, Username = admin.Username };

            _context.Admins.Add(ob);
            await _context.SaveChangesAsync();

            // return CreatedAtAction(nameof(GetAdmin), new { id = admin.AdminId }, admin);
            return Ok();
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, [FromBody] Admin admin)
        {
            if (id != admin.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(admin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdminExists(id))
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

        // DELETE: api/Admin/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdminExists(int id)
        {
            return _context.Admins.Any(e => e.AdminId == id);
        }
    }
}
