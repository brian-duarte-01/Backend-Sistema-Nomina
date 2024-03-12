using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Repositorie;
using Sistema_Nominas.Request;
using Sistema_Nominas.Service;

namespace Sistema_Nominas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private EmpresaRepositorie er = new EmpresaRepositorie(new EmpresaService());


        // realizamos la peticion Get
        [HttpGet]
        public ActionResult getEmpresa()
        {
            return er.getEmpresa();
        }

        // realizamos la peticion Post
        [HttpPost]
        public ActionResult postEmpresa([FromBody] EmpresaRequest request)
        {
            return er.postEmpresa(request);
        }

        // realizamos la peticion Put
        [HttpPut]
        //creamos una ruta para enviar el ID.
        [Route("{id}")]
        public ActionResult putEmpresa(int id, [FromBody] EmpresaRequest request)
        {
            return er.putEmpresa(id, request);
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
