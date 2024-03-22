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
    public class AguinaldoController : ControllerBase
    {

        private AguinaldoRepositorie ar = new AguinaldoRepositorie(new AguinaldoService());

        [HttpGet]
        public ActionResult get()
        {
            return ar.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string empleado="")
        {
            return ar.getBuscar(empleado);
        }


        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return ar.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] AguinaldoRequest request)
        {
            return ar.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] AguinaldoRequest request)
        {
            return ar.put(id,request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return ar.delete(id);
        }
    }
}
