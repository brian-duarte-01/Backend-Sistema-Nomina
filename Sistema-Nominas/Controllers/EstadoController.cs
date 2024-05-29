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
    public class EstadoController : ControllerBase
    {

        private EstadoRepositorie er = new EstadoRepositorie(new EstadoService());

        [HttpGet]
        [Route("Count")]
        public ActionResult getCountEstado()
        {
            return er.getCountEstado();
        }

        [HttpGet]   
        public ActionResult getEstado()
        {
            return er.getEstado();
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult obtenerEstado(int id)
        {
            return er.obtenerEstado(id);
        }

        [HttpPost]
        public ActionResult postEstado([FromBody] EstadoRequest request)
        {
            return er.postEstado(request);  
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult putEstado(int id, [FromBody] EstadoRequest request)
        {
            return er.putEstado(id, request);   
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult deleteEstado(int id)
        {
            return er.deleteEstado(id);
        }

       
    }
}
