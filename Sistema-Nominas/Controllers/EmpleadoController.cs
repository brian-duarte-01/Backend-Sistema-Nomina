using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Repositorie;
using Sistema_Nominas.Request;
using Sistema_Nominas.Service;

namespace Sistema_Nominas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private empleadoRepositorie er = new empleadoRepositorie(new empleadoService());

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscarEmpleado(string nit = "")
        {
            return er.getBuscarEmpleado(nit);
        }


        [HttpGet]
        [Route("Count")]
        public ActionResult getCountEmpleado()
        {
            return er.getCountEmpleado();
        }


        [HttpGet]
        public ActionResult getEmpleado()
        {
            return er.getEmpleado();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult getVisualizarEmpleado(int id)
        {
            return er.getVisualizarEmpleado(id);
        }

        [HttpPost]
        public ActionResult postEmpleado([FromBody] EmpleadoRequest request)
        {
            return er.postEmpleado(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult putEmpleado(int id, [FromBody] EmpleadoRequest request)
        {
            return er.putEmpleado(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult deleteEmpleado(int id)
        {
            return er.deleteEmpleado(id);
        }
    }
}
