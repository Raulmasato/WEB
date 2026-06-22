namespace ElectroJoule.Web.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Categoria { get; set; } = "";
    public string Marca { get; set; } = "";
    public string ImagenUrl { get; set; } = "";
    public string Slug { get; set; } = "";
}

public class FiltroProducto
{
    public string? Buscar { get; set; }
    public string? Categoria { get; set; }
    public string? Marca { get; set; }
}
