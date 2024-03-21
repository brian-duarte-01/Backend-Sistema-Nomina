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
    public class PagoController : ControllerBase
    {

        private PrestacionesRepositorie pr = new PrestacionesRepositorie(new PagoService());

        [HttpGet]
        public ActionResult get()
        {
            return pr.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string empleado="")
        {
            return pr.getBuscar(empleado);
        }

        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return pr.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] PagosRequest request)
        {
            return pr.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] PagosRequest request)
        {
            return pr.put(id,request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return pr.delete(id);
        }
    }
}
