using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelacionNaN.Models;

    public class RelacionNaNContext : DbContext
    {
        public RelacionNaNContext (DbContextOptions<RelacionNaNContext> options)
            : base(options)
        {
        }

        public DbSet<RelacionNaN.Models.ExamenAlumno> ExamenAlumno { get; set; }
        public DbSet<RelacionNaN.Models.Examen> Examen { get; set; }
        public DbSet<RelacionNaN.Models.Alumno> Alumno { get; set; }
    }
