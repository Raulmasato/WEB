namespace ElectroJoule.Web.Models;

public class CarritoItem
{
    public int ProductoId { get; set; }
    public string Nombre { get; set; } = "";
    public decimal PrecioUnit { get; set; }
    public int Cantidad { get; set; }
    public string ImagenUrl { get; set; } = "";
    public decimal Subtotal => PrecioUnit * Cantidad;
}

public class Carrito
{
    public List<CarritoItem> Items { get; set; } = new();
    public decimal Total => Items.Sum(i => i.Subtotal);
    public int CantidadTotal => Items.Sum(i => i.Cantidad);
}

public class CheckoutViewModel
{
    public Carrito Carrito { get; set; } = new();
    public string Nombre { get; set; } = "";
    public string Email { get; set; } = "";
    public string Telefono { get; set; } = "";
    public string Dni { get; set; } = "";
}
