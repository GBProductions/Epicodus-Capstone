using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OscarAPI.Models;

namespace OscarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NominationsController : ControllerBase
    {
        private readonly OscarAPIContext _db;

        public NominationsController(OscarAPIContext db)
        {
            _db = db;
        }
    
        // GET api/nominations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nomination>>> Get()
        {
            return await _db.Nominations.ToListAsync();
        }

        // GET: api/Nominations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Nomination>> GetNomination(int id)
        {
            var nomination = await _db.Nominations.FindAsync(id);

            if (nomination == null)
            {
                return NotFound();
            }

            return nomination;
        }

        // PUT: api/Nominations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Nomination nomination)
        {
            if (id != nomination.NominationId)
            {
                return BadRequest();
            }

            _db.Entry(nomination).State = EntityState.Modified;
            
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NominationExists(id))
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

        // POST api/nominations
        [HttpPost]
        public async Task<ActionResult<Nomination>> Post(Nomination nomination)
        {
            _db.Nominations.Add(nomination);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNomination), new { id = nomination.NominationId }, nomination);
        }

        // DELETE: api/Nominations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNomination (int id)
        {
            var nomination = await _db.Nominations.FindAsync(id);
            if (nomination == null)
            {
                return NotFound();
            }

            _db.Nominations.Remove(nomination);
            await _db.SaveChangesAsync();

            return NoContent();
        }
        
        private bool NominationExists(int id)
        {
            return _db.Nominations.Any(e => e.NominationId == id);
        }
    }
}