using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaWebApp.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [MaxLength(15)][Required]
        public string Nombre { get; set; }
        [MaxLength(40)][Required]
        public string Apellidos { get; set; }
        [Phone]
        [Required]
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "El formato del email es incorrecto")]
        public string Email { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
