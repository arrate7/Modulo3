using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DepencyInjection.Models;
using Microsoft.AspNetCore.Identity;

namespace DepencyInjection.Services
{
    public class EmpleadosServices : IEmpleado
    {
        private DepencyInjectionContext _context;

        public EmpleadosServices(DepencyInjectionContext context)
        {
            _context = context;
      
        }

        public async Task AddEmpleado(Empleado empleado)
        {


            _context.Add(empleado);
            await _context.SaveChangesAsync();
        }

        public async Task BorrarEmpleado(Empleado empleado)
        {
            _context.Remove(empleado);
            await _context.SaveChangesAsync();
        }

        public bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.Id == id);
        }

        public async Task<Empleado> GetEmpleado(int? id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public List<Empleado> GetEmpleados()
        {
            return  _context.Empleados.ToList();
        }

        public async Task UpdateEmpleado(Empleado empleado)
        {
            _context.Update(empleado);
            await _context.SaveChangesAsync();
        }

        public void GetNombre()
        {

        }
    }
}
