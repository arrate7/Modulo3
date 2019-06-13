using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1a1.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        public Biografia Biografia { get; set; }
    }
}
