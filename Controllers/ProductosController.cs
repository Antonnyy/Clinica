using ClinicaApi.Data;
using ClinicaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    // GET: api/productos
    [HttpGet]
    public ActionResult<IEnumerable<Producto>> GetAll()
    {
        return Ok(ClinicaData.Productos);
    }

    // GET: api/productos/{id}
    [HttpGet("{id:int}")]
    public ActionResult<Producto> GetById(int id)
    {
        var producto = ClinicaData.Productos.FirstOrDefault(x => x.Id == id);
        if (producto == null)
        {
            return NotFound(new
            {
                mensaje = $"No existe un producto con ID {id}"
            });
        }
        return Ok(producto);
    }

    // POST: api/productos
    [HttpPost]
    public ActionResult<Producto> Create([FromBody] Producto nuevoProducto)
    {
        if (string.IsNullOrWhiteSpace(nuevoProducto.Codigo))
        {
            return BadRequest(new
            {
                mensaje = "El código es obligatorio"
            });
        }

        if (string.IsNullOrWhiteSpace(nuevoProducto.Nombre))
        {
            return BadRequest(new
            {
                mensaje = "El nombre es obligatorio"
            });
        }

        if (nuevoProducto.Precio < 0)
        {
            return BadRequest(new
            {
                mensaje = "El precio no puede ser negativo"
            });
        }

        if (nuevoProducto.Stock < 0)
        {
            return BadRequest(new
            {
                mensaje = "El stock no puede ser negativo"
            });
        }

        if (nuevoProducto.Descuento < 0 || nuevoProducto.Descuento > 100)
        {
            return BadRequest(new
            {
                mensaje = "El descuento debe estar entre 0 y 100"
            });
        }

        // Asignar ID autoincremental
        nuevoProducto.Id = ClinicaData.Productos.Count == 0
            ? 1
            : ClinicaData.Productos.Max(x => x.Id) + 1;

        // Si CategoriaId no viene asignada pero sí el nombre, mapearlo
        if (nuevoProducto.CategoriaId == 0 && !string.IsNullOrWhiteSpace(nuevoProducto.Categoria))
        {
            var cat = ClinicaData.Categorias.FirstOrDefault(c =>
                c.Nombre.Equals(nuevoProducto.Categoria, StringComparison.OrdinalIgnoreCase));
            if (cat != null) nuevoProducto.CategoriaId = cat.Id;
        }

        ClinicaData.Productos.Add(nuevoProducto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = nuevoProducto.Id },
            nuevoProducto
        );
    }

    // PUT: api/productos/{id}
    [HttpPut("{id:int}")]
    public ActionResult<Producto> Update(int id, [FromBody] Producto datos)
    {
        var producto = ClinicaData.Productos.FirstOrDefault(x => x.Id == id);
        if (producto == null)
        {
            return NotFound(new
            {
                mensaje = $"No existe un producto con ID {id}"
            });
        }

        if (string.IsNullOrWhiteSpace(datos.Codigo))
        {
            return BadRequest(new
            {
                mensaje = "El código es obligatorio"
            });
        }

        if (string.IsNullOrWhiteSpace(datos.Nombre))
        {
            return BadRequest(new
            {
                mensaje = "El nombre es obligatorio"
            });
        }

        if (datos.Precio < 0)
        {
            return BadRequest(new
            {
                mensaje = "El precio no puede ser negativo"
            });
        }

        if (datos.Stock < 0)
        {
            return BadRequest(new
            {
                mensaje = "El stock no puede ser negativo"
            });
        }

        if (datos.Descuento < 0 || datos.Descuento > 100)
        {
            return BadRequest(new
            {
                mensaje = "El descuento debe estar entre 0 y 100"
            });
        }

        // Actualizar datos
        producto.Codigo = datos.Codigo;
        producto.Nombre = datos.Nombre;
        producto.CategoriaId = datos.CategoriaId > 0 ? datos.CategoriaId : producto.CategoriaId;
        producto.Categoria = string.IsNullOrWhiteSpace(datos.Categoria) ? producto.Categoria : datos.Categoria;
        producto.Laboratorio = datos.Laboratorio ?? producto.Laboratorio;
        producto.Presentacion = datos.Presentacion ?? producto.Presentacion;
        producto.Precio = datos.Precio;
        producto.Stock = datos.Stock;
        producto.Descuento = datos.Descuento;
        producto.RequiereReceta = datos.RequiereReceta;
        producto.Imagen = datos.Imagen ?? producto.Imagen;
        producto.Descripcion = datos.Descripcion ?? producto.Descripcion;

        return Ok(producto);
    }

    // DELETE: api/productos/{id}
    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var producto = ClinicaData.Productos.FirstOrDefault(x => x.Id == id);
        if (producto == null)
        {
            return NotFound(new
            {
                mensaje = $"No existe un producto con ID {id}"
            });
        }

        ClinicaData.Productos.Remove(producto);

        return Ok(new
        {
            mensaje = $"Producto con ID {id} eliminado correctamente",
            eliminado = producto
        });
    }
}
