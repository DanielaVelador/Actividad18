using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Album
    {
        public int? Id { get; set; }
        public string? Title { get; set; }

        public string? Artist { get; set; }

        public DateTime? FechaLanzamiento { get; set; }

        public DateTime? FechaAdquicision { get; set; }

        public int UbicacionId {get; set; }
        public virtual Ubicacion? Ubicacion { get; set;}
    }
}
