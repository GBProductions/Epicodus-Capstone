using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OscarAPI.Models;

namespace OscarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly OscarAPIContext _db;

        public FilmsController(OscarAPIContext db)
        {
            _db = db;
        }
    
        // GET api/films
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> Get()
        {
            return await _db.Films.ToListAsync();
        }

        // POST api/films
        [HttpPost]
        public async Task<ActionResult<Film>> Post(Film film)
        {
            _db.Films.Add(film);
            await _db.SaveChangesAsync();

            return CreatedAtAction("Post", new { id = film.FilmId }, film);
        }
    }
}