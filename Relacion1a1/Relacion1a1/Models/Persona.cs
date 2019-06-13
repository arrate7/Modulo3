using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1a1.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Dni Dni { get; set; }
    }
}
