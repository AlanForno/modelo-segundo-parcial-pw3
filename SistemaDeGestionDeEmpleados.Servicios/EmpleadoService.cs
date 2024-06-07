using Microsoft.EntityFrameworkCore;
using SistemaDeGestionDeEmpleados.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionDeEmpleados.Servicios;

public interface IEmpleadoService
{
    void AgregarEmpleado(Empleado empleado);
    List<Empleado> ListarEmpleados();

    List<Empleado> FiltrarEmpleadosPorSucursal(int id);
}

public class EmpleadoService : IEmpleadoService
{

    private readonly Pw3SegundoParcialContext _context;

    public EmpleadoService(Pw3SegundoParcialContext context)
    {
        _context = context;
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        _context.Add(empleado);
        _context.SaveChanges();
    }

    public List<Empleado> FiltrarEmpleadosPorSucursal(int id)
    {
        return _context.Empleados.Where(e => e.IdSucursal == id).ToList();
    }

    public List<Empleado> ListarEmpleados()
    {
        return _context.Empleados.ToList();
    }

}
