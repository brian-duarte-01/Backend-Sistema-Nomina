using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Repositorie;
using Sistema_Nominas.Request;
using Sistema_Nominas.Service;

namespace Sistema_Nominas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndemizacionController : ControllerBase
    {

        private IndemizacionRepositorie ir = new IndemizacionRepositorie(new IndemizacionService());

        [HttpGet]
        public ActionResult get()
        {
            return ir.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string empleado="")
        {
            return ir.getBuscar(empleado);
        }

        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return ir.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] IndemizacionRequest request)
        {
            return ir.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] IndemizacionRequest request)
        {
            return ir.put(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return ir.delete(id);
        }
    }
}
