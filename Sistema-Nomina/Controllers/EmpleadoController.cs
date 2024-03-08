using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Nomina.Interface;
using Sistema_Nomina.Repositorie;
using Sistema_Nomina.Request;
using Sistema_Nomina.Service;

namespace Sistema_Nomina.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private EmpleadoRepositorie er = new EmpleadoRepositorie(new EmpleadoService());

        [HttpGet]
        [Route("Buscar")]
        public ActionResult getBuscarEmpleado(string primer_nombre="")
        {
            return er.getBuscarEmpleado(primer_nombre);
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
        [Route("Visualizar/{id}")]
        public ActionResult getVisualizarEmpleado(int id)
        {
            return er.getVisualizarEmpleado(id);
        }

        [HttpPost]
        public ActionResult postEmpleado([FromBody] empleadoRequest request)
        {
            return er.postEmpleado(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult putEmpleado(int id, [FromBody] empleadoRequest request)
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
