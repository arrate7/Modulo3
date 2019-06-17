using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionNaN.Models
{
    public class ExamenAlumno
    {
        public int Id { get; set; }
        public double Nota { get; set; }

        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }

        public int ExamenId { get; set; }
        public Examen Examen { get; set; }
    }
}
