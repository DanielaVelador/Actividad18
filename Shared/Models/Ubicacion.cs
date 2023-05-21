using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_18.Shared.Models
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public int NoEstante { get; set; }
        public int Piso { get; set; }

        public virtual ICollection<Album>? Albums { get; set; }
    }
}
