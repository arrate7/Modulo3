using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaWebApp.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Nombre { get; set; }
        [StringLength(3,MinimumLength = 3)]
        public string Codigo { get; set; }

        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public List<Empleado> Empleados { get; set; }

    }   
}
