using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerAppi.ADO.net;
using PrimerAppi.Modelos;

namespace PrimerAppi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("/producto/{descripciones}")]
        public Producto ObtenerProductoyDescripciones(string descripciones)
        {
            Producto producto=ManejadorProducto.ObtenerProducto(descripciones);
            return producto;
        }

        [HttpGet("/productos")]
        public List<Producto> ObtenerProducto() // obtener todo lo de la base
        {
            return ManejadorProducto.obtenerProducto();
        }
    }
}
