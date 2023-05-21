using Actividad_18.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Actividad_18.Server.Contexto
{
    public class AlbumsContexto : DbContext
    {
        public AlbumsContexto(DbContextOptions<AlbumsContexto> options):base (options) 
        {
            
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<AlbumF>  AlbumsF { get; set; }
    }
}
