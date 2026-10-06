namespace ClinicaApi.Models;

public class Medico
{
    public int Id { get; set; }
    public string Cmp { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;
    public string Especialidad { get; set; } = string.Empty;
    public int AniosExperiencia { get; set; }
    public string HorarioAtencion { get; set; } = string.Empty;
    public decimal TarifaConsulta { get; set; }
    public double Calificacion { get; set; }
    public string Foto { get; set; } = string.Empty;
}
