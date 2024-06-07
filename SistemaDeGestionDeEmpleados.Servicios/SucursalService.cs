using Microsoft.EntityFrameworkCore;
using SistemaDeGestionDeEmpleados.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeGestionDeEmpleados.Servicios;

public interface ISucursalService
{
    List<Sucursal> ListarSucursales();
}

public class SucursalService : ISucursalService
{

    private readonly Pw3SegundoParcialContext _context;

    public SucursalService(Pw3SegundoParcialContext context)
    {
        _context = context;
    }

    public List<Sucursal> ListarSucursales()
    {
        return _context.Sucursals.Where(s => s.Eliminada == false).OrderBy(s => s.Direccion).ToList();
    }

}
