﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1a1.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required][StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        [MaxLength(30)]
        public string Nacionalidad { get; set; }

        public Biografia Biografia { get; set; }
    }
}
