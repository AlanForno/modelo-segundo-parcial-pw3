using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaDeGestionDeEmpleados.Data.EF;
using SistemaDeGestionDeEmpleados.Servicios;

namespace SistemaDeGestionDeEmpleados.Web.Controllers;

public class EmpleadoController : Controller
{

    private readonly IEmpleadoService _empleadoService;
    private readonly ISucursalService _sucursalService;

    public EmpleadoController(IEmpleadoService empleadoService, ISucursalService sucursalService)
    {
        _empleadoService = empleadoService;
        _sucursalService = sucursalService;
    }

    public IActionResult Crear()
    {
        ViewBag.Sucursales = _sucursalService.ListarSucursales();
        return View();
    }

    [HttpPost]
    public IActionResult Crear(Empleado empleado)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Sucursales = _sucursalService.ListarSucursales();
            return View();
        }

        _empleadoService.AgregarEmpleado(empleado);

        return RedirectToAction("Listar");
    }

    public IActionResult Listar()
    {
        ViewBag.Sucursales = _sucursalService.ListarSucursales();
        var empleados = _empleadoService.ListarEmpleados();
        return View(empleados);
    }

    public IActionResult FiltrarPorSucursal(int idSucursal)
    {
        ViewBag.Sucursales = _sucursalService.ListarSucursales();
        var empleados = _empleadoService.FiltrarEmpleadosPorSucursal(idSucursal);

        if (idSucursal == 0)
        {
            empleados = _empleadoService.ListarEmpleados();
        }

        return View("Listar", empleados);
    }

}

