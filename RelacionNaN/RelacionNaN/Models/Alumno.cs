using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionNaN.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumMatricula { get; set; }

        public List<ExamenAlumno> ExamenAlumnos { get; set; }
    }
}
