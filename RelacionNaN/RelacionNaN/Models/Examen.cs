using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionNaN.Models
{
    public class Examen
    {
        public int Id { get; set; }
        public string Asignatura { get; set; }
        public string Codigo { get; set; }

        public List<ExamenAlumno> ExamenAlumnos { get; set; }
    }
}
