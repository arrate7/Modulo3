using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1aN.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
