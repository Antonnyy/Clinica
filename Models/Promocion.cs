namespace ClinicaApi.Models;

public class Promocion
{
    public int Id { get; set; }
    public string CodigoCupon { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public int PorcentajeDescuento { get; set; }
    public string CategoriaAplicable { get; set; } = string.Empty;
    public string Vigencia { get; set; } = string.Empty;
    public bool Activa { get; set; }
}
