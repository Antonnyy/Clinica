using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Categoria>> GetAll() => ClinicaData.Categorias;

    [HttpGet("{id:int}")]
    public ActionResult<Categoria> GetById(int id)
    {
        var item = ClinicaData.Categorias.FirstOrDefault(x => x.Id == id);
        return item == null ? NotFound(new { mensaje = $"No existe categoría con ID {id}" }) : Ok(item);
    }
}
