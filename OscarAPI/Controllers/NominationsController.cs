using System.Collections.Generic;
using System.Threading.Tasks;
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

        // POST api/nominations
        [HttpPost]
        public async Task<ActionResult<Nomination>> Post(Nomination nomination)
        {
            _db.Nominations.Add(nomination);
            await _db.SaveChangesAsync();

            return CreatedAtAction("Post", new { id = nomination.NominationId }, nomination);
        }
    }
}