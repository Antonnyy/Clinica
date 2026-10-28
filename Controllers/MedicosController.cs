using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicosController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Medico>> GetAll() => ClinicaData.Medicos;

    [HttpGet("{id:int}")]
    public ActionResult<Medico> GetById(int id)
    {
        var item = ClinicaData.Medicos.FirstOrDefault(x => x.Id == id);
        return item == null ? NotFound(new { mensaje = $"No existe médico con ID {id}" }) : Ok(item);
    }
}
