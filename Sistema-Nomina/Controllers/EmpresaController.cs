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
    public class EmpresaController : ControllerBase
    {

        private empresaRepositorie er = new empresaRepositorie(new EmpresaService());


        // realizamos la peticion Get
        [HttpGet]
        public ActionResult getEmpresa()
        {
            return er.getEmpresa();
        }

        // realizamos la peticion Post
        [HttpPost]
        public ActionResult postEmpresa([FromBody] empresaRequest request)
        {
            return er.postEmpresa(request);
        }

        // realizamos la peticion Put
        [HttpPut]
        //creamos una ruta para enviar el ID.
        [Route("{id}")]
        public ActionResult putEmpresa(int id, [FromBody] empresaRequest request)
        {
            return er.putEmpresa(id,request);
        }

        // realizamos la peticion Delete
        [HttpDelete]
        //creamos una ruta para enviar el ID.
        [Route("{id}")]
        public ActionResult deleteEmpresa(int id)
        {
            return er.deleteEmpresa(id);
        }
    }
}
