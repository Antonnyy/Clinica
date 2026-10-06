using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicosController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Medico>> Get() => ClinicaData.Medicos;
}
