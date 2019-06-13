using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1a1.Models
{
    public class Biografia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaEdicion { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
