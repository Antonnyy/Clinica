using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiciosController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Servicio>> Get() => ClinicaData.Servicios;
}
