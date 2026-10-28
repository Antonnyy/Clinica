using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiciosController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Servicio>> GetAll() => ClinicaData.Servicios;

    [HttpGet("{id:int}")]
    public ActionResult<Servicio> GetById(int id)
    {
        var item = ClinicaData.Servicios.FirstOrDefault(x => x.Id == id);
        return item == null ? NotFound(new { mensaje = $"No existe servicio con ID {id}" }) : Ok(item);
    }
}
