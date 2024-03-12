using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Interface;
using WebApplication2.Repositorie;
using WebApplication2.Request;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {

        private NotaRepositorie nr = new NotaRepositorie(new NotaService());

        [HttpGet]
        public ActionResult getNota()
        {
            return nr.getNota();
        }

        [HttpPost]
        public ActionResult postNota([FromBody] NotaRequest request)
        {
            return nr.postNota(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult putNota(int id, [FromBody] NotaRequest request)
        {
            return nr.putNota(id, request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult deleteNota(int id)
        {
            return nr.deleteNota(id);
        }
    }
}
