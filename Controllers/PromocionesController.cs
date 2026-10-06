using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PromocionesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Promocion>> Get() => ClinicaData.Promociones;
}
