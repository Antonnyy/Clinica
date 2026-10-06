namespace ClinicaApi.Models;

public class Servicio
{
    public int Id { get; set; }
    public string Codigo { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public string Especialidad { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int DuracionMinutos { get; set; }
    public string Modalidad { get; set; } = string.Empty;
    public string Imagen { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
}
