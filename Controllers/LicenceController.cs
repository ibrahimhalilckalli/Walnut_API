using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Walnut_API.Models;
using Walnut_API.Models.Context;

namespace Walnut_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LicenceController : Controller
    {
        private readonly WalnutDbContext _context;

        public LicenceController(WalnutDbContext context)
        {
           _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Licence>>> GetLicences()
        {
            return await _context.Licences.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Licence>> GetLicence(int id)
        {
            var licence = await _context.Licences.FindAsync(id);

            if (licence == null)
            {
                return NotFound();
            }

            return licence;
        }

        [HttpPost]
        public async Task<ActionResult<Licence>> PostLicence(Licence licence)
        {
            _context.Licences.Add(licence);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLicence), new { id = licence.Id }, licence);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLicence(int id, Licence licence)
        {
            if (id != licence.Id)
            {
                return BadRequest();
            }

            _context.Entry(licence).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLicence(int id)
        {
            var licence = await _context.Licences.FindAsync(id);

            if (licence == null)
            {
                return NotFound();
            }

            _context.Licences.Remove(licence);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
