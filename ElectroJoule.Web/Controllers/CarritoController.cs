using ElectroJoule.Web.Models;
using ElectroJoule.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectroJoule.Web.Controllers;

public class CarritoController : Controller
{
    private readonly CarritoService _carrito;
    private readonly ProductoService _productos;

    public CarritoController(CarritoService carrito, ProductoService productos)
    {
        _carrito = carrito;
        _productos = productos;
    }

    public IActionResult Index()
    {
        var carrito = _carrito.ObtenerCarrito();
        ViewBag.CarritoCount = carrito.CantidadTotal;
        return View(carrito);
    }

    [HttpPost]
    public IActionResult Agregar(int productoId, int cantidad = 1)
    {
        var producto = _productos.ObtenerPorId(productoId);
        if (producto != null)
            _carrito.Agregar(producto, cantidad);

        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            return Json(new { ok = true, total = _carrito.ObtenerCarrito().CantidadTotal });

        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Actualizar(int productoId, int cantidad)
    {
        _carrito.ActualizarCantidad(productoId, cantidad);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Quitar(int productoId)
    {
        _carrito.Quitar(productoId);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Vaciar()
    {
        _carrito.Vaciar();
        return RedirectToAction("Index");
    }

    public IActionResult Checkout()
    {
        var carrito = _carrito.ObtenerCarrito();
        if (!carrito.Items.Any())
            return RedirectToAction("Index");

        ViewBag.CarritoCount = carrito.CantidadTotal;
        return View(new CheckoutViewModel { Carrito = carrito });
    }
}
