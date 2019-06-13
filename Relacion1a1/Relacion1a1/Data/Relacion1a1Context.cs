using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Relacion1a1.Models;

    public class Relacion1a1Context : DbContext
    {
        public Relacion1a1Context (DbContextOptions<Relacion1a1Context> options)
            : base(options)
        {
        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Dni> Dni { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Biografia> Biografia { get; set; }

    }
