using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpresaWebApp.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Direccion { get; set; }
        [Required]
        public string Cif { get; set; }
        [MaxLength(20)]
        [Required]
        public string Pais { get; set; }

        public List<Departamento> Departamentos { get; set; }
    }
}
