using ElectroJoule.Web.Models;
using ElectroJoule.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectroJoule.Web.Controllers;

public class HomeController : Controller
{
    private readonly ProductoService _productos;
    private readonly CarritoService _carrito;

    public HomeController(ProductoService productos, CarritoService carrito)
    {
        _productos = productos;
        _carrito = carrito;
    }

    public IActionResult Index([FromQuery] FiltroProducto filtro)
    {
        ViewBag.Productos = _productos.Filtrar(filtro);
        ViewBag.Categorias = _productos.ObtenerCategorias();
        ViewBag.Marcas = _productos.ObtenerMarcas();
        ViewBag.Filtro = filtro;
        ViewBag.CarritoCount = _carrito.ObtenerCarrito().CantidadTotal;
        return View();
    }

    public IActionResult Detalle(string slug)
    {
        var producto = _productos.ObtenerPorSlug(slug);
        if (producto == null) return NotFound();
        ViewBag.CarritoCount = _carrito.ObtenerCarrito().CantidadTotal;
        return View(producto);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View();
}
