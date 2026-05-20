using Parcial2Progra3by;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Progra3by
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public List<Cancion> Canciones { get; set; } = new List<Cancion>();
        public DateTime FechaPublicacion { get; set; }
    }
}
