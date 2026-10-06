namespace ClinicaApi.Models;

public class Producto
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public int CategoriaId { get; set; }
    public string Categoria { get; set; } = string.Empty;
    public string Laboratorio { get; set; } = string.Empty;
    public string Presentacion { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Descuento { get; set; }
    public int Stock { get; set; }
    public bool RequiereReceta { get; set; }
    public string Imagen { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
}
