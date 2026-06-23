using ElectroJoule.Web.Models;
using ElectroJoule.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace ElectroJoule.Web.Controllers;

public class PagoController : Controller
{
    private readonly MercadoPagoService _mp;
    private readonly CarritoService _carrito;

    public PagoController(MercadoPagoService mp, CarritoService carrito)
    {
        _mp = mp;
        _carrito = carrito;
    }

    [HttpPost]
    public async Task<IActionResult> Procesar(CheckoutViewModel model)
    {
        model.Carrito = _carrito.ObtenerCarrito();
        if (!model.Carrito.Items.Any())
            return RedirectToAction("Index", "Carrito");

        if (!ModelState.IsValid)
        {
            ViewBag.CarritoCount = model.Carrito.CantidadTotal;
            return View("~/Views/Carrito/Checkout.cshtml", model);
        }

        var baseUrl = $"{Request.Scheme}://{Request.Host}";
        var (initPoint, error) = await _mp.CrearPreferenciaAsync(model, baseUrl);

        if (error != null)
        {
            ViewBag.Error = $"No se pudo conectar con Mercado Pago: {error}";
            ViewBag.CarritoCount = model.Carrito.CantidadTotal;
            return View("~/Views/Carrito/Checkout.cshtml", model);
        }

        return Redirect(initPoint!);
    }

    public IActionResult Exito([FromQuery] string? collection_id, [FromQuery] string? external_reference)
    {
        _carrito.Vaciar();
        ViewBag.NumeroOperacion = collection_id ?? "—";
        ViewBag.Referencia = external_reference ?? "—";
        return View();
    }

    public IActionResult Error([FromQuery] string? collection_id)
    {
        ViewBag.NumeroOperacion = collection_id ?? "—";
        return View();
    }

    public IActionResult Pendiente([FromQuery] string? collection_id)
    {
        ViewBag.NumeroOperacion = collection_id ?? "—";
        return View();
    }
}
