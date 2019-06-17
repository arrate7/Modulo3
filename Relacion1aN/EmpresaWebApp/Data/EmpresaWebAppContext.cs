using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpresaWebApp.Models;

    public class EmpresaWebAppContext : DbContext
    {
        public EmpresaWebAppContext (DbContextOptions<EmpresaWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmpresaWebApp.Models.Departamento> Departamento { get; set; }
        public DbSet<EmpresaWebApp.Models.Empleado> Empleados { get; set; }
    }
