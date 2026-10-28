using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PromocionesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Promocion>> GetAll() => ClinicaData.Promociones;

    [HttpGet("{id:int}")]
    public ActionResult<Promocion> GetById(int id)
    {
        var item = ClinicaData.Promociones.FirstOrDefault(x => x.Id == id);
        return item == null ? NotFound(new { mensaje = $"No existe promoción con ID {id}" }) : Ok(item);
    }
}
