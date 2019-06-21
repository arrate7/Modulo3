using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DepencyInjection.Models;

    public class DepencyInjectionContext : DbContext
    {
        public DepencyInjectionContext (DbContextOptions<DepencyInjectionContext> options)
            : base(options)
        {
        }

        public DbSet<DepencyInjection.Models.Empleado> Empleados { get; set; }
    }
