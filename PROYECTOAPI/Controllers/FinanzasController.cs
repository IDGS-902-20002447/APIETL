using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROYECTOAPI.Context;

namespace PROYECTOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class FinanzasController : ControllerBase
    {
        private readonly AppDbContext _context;
        public FinanzasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("MasVta")]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.mayor_vendido_producto.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("MenosVta")]
        public ActionResult Get_ProductoMenosVendido()
        {
            try
            {
                return Ok(_context.menor_vendido_producto.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("Valores")]
        public ActionResult Get_ValoresCaldulados()
        {
            try
            {
                return Ok(_context.valores_calculados.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet("VtaMes")]
        public ActionResult Get_VentaMensual()
        {
            try
            {
                return Ok(_context.ventas_mensuales.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Top5Clientes")]
        public ActionResult Get_Top_Clientes()
        {
            try
            {
                return Ok(_context.clientes_mayores_pedidos.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ProductosEx")]
        public ActionResult Get_Productos()
        {
            try
            {
                return Ok(_context.producto_existencia.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Materia")]
        public ActionResult Get_Materia()
        {
            try
            {
                return Ok(_context.materia_prima_existencia.ToList());

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
