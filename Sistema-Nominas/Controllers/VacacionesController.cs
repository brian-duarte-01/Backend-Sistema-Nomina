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
    public class VacacionesController : ControllerBase
    {

        private VacacionesRRepositorie vr = new VacacionesRRepositorie(new VacacionesService());

        [HttpGet]
        public ActionResult get()
        {
            return vr.get();
        }

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscar(string empleado="")
        {
            return vr.getBuscar(empleado);
        }

        [HttpGet]
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizar(int id)
        {
            return vr.getVisualizar(id);
        }

        [HttpPost]
        public ActionResult post([FromBody] VacacionesRequest request)
        {
            return vr.post(request);    
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult put(int id, [FromBody] VacacionesRequest request)
        {
            return vr.put(id,request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult delete(int id)
        {
            return vr.delete(id);
        }
    }
}
