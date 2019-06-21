using DepencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepencyInjection.Services
{
    public interface IEmpleado
    {
        Task<Empleado> GetEmpleado(int? id);
        List<Empleado> GetEmpleados();
        Task AddEmpleado(Empleado empleado);
        Task UpdateEmpleado(Empleado empleado);
        bool EmpleadoExists(int id);
        Task BorrarEmpleado(Empleado empleado);

    }
}
