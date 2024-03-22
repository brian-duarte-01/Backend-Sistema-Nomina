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
    public class Bono14Controller : ControllerBase
    {


        private Bono14Repositorie br = new Bono14Repositorie(new Bono14Service());

        [HttpGet]
        public ActionResult get()
        {
            return br.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string empleado="")
        {
            return br.getBuscar(empleado);
        }

        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return br.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] Bono14Request request)
        {
            return br.post(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] Bono14Request request)
        {
            return br.put(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return br.delete(id);
        }
    }
}
