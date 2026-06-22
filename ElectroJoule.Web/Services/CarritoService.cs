using ElectroJoule.Web.Models;
using Newtonsoft.Json;

namespace ElectroJoule.Web.Services;

public class CarritoService
{
    private const string SessionKey = "Carrito";
    private readonly IHttpContextAccessor _http;

    public CarritoService(IHttpContextAccessor http) => _http = http;

    private ISession Session => _http.HttpContext!.Session;

    public Carrito ObtenerCarrito()
    {
        var json = Session.GetString(SessionKey);
        return string.IsNullOrEmpty(json) ? new Carrito() : JsonConvert.DeserializeObject<Carrito>(json)!;
    }

    private void Guardar(Carrito carrito) =>
        Session.SetString(SessionKey, JsonConvert.SerializeObject(carrito));

    public void Agregar(Producto producto, int cantidad = 1)
    {
        var carrito = ObtenerCarrito();
        var item = carrito.Items.FirstOrDefault(i => i.ProductoId == producto.Id);
        if (item == null)
            carrito.Items.Add(new CarritoItem
            {
                ProductoId = producto.Id,
                Nombre = producto.Nombre,
                PrecioUnit = producto.Precio,
                Cantidad = cantidad,
                ImagenUrl = producto.ImagenUrl
            });
        else
            item.Cantidad += cantidad;
        Guardar(carrito);
    }

    public void ActualizarCantidad(int productoId, int cantidad)
    {
        var carrito = ObtenerCarrito();
        var item = carrito.Items.FirstOrDefault(i => i.ProductoId == productoId);
        if (item != null)
        {
            if (cantidad <= 0) carrito.Items.Remove(item);
            else item.Cantidad = cantidad;
        }
        Guardar(carrito);
    }

    public void Quitar(int productoId)
    {
        var carrito = ObtenerCarrito();
        carrito.Items.RemoveAll(i => i.ProductoId == productoId);
        Guardar(carrito);
    }

    public void Vaciar()
    {
        Session.Remove(SessionKey);
    }
}
