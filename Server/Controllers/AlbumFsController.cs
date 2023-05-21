using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Actividad_18.Server.Contexto;
using Actividad_18.Shared.Models;

namespace Actividad_18.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumFsController : ControllerBase
    {
        private readonly AlbumsContexto _context;

        public AlbumFsController(AlbumsContexto context)
        {
            _context = context;
        }

        // GET: api/AlbumFs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlbumF>>> GetAlbumsF()
        {
          if (_context.AlbumsF == null)
          {
              return NotFound();
          }
            return await _context.AlbumsF.ToListAsync();
        }

        // GET: api/AlbumFs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlbumF>> GetAlbumF(int id)
        {
          if (_context.AlbumsF == null)
          {
              return NotFound();
          }
            var albumF = await _context.AlbumsF.FindAsync(id);

            if (albumF == null)
            {
                return NotFound();
            }

            return albumF;
        }

        // PUT: api/AlbumFs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlbumF(int id, AlbumF albumF)
        {
            if (id != albumF.Id)
            {
                return BadRequest();
            }

            _context.Entry(albumF).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlbumFExists(id))
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

        // POST: api/AlbumFs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlbumF>> PostAlbumF(AlbumF albumF)
        {
          if (_context.AlbumsF == null)
          {
              return Problem("Entity set 'AlbumsContexto.AlbumsF'  is null.");
          }
            _context.AlbumsF.Add(albumF);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlbumF", new { id = albumF.Id }, albumF);
        }

        // DELETE: api/AlbumFs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlbumF(int id)
        {
            if (_context.AlbumsF == null)
            {
                return NotFound();
            }
            var albumF = await _context.AlbumsF.FindAsync(id);
            if (albumF == null)
            {
                return NotFound();
            }

            _context.AlbumsF.Remove(albumF);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlbumFExists(int id)
        {
            return (_context.AlbumsF?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
