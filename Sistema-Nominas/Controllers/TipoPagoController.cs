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
    public class TipoPagoController : ControllerBase
    {

        private TipoPagoRepositorie tr = new TipoPagoRepositorie(new TipoPagoService());

        [HttpGet]
        [Route("Count")]
        public ActionResult getCountTipoPago()
        {
            return tr.getCountTipoPago();
        }

        [HttpGet]
        public ActionResult getTipoPago()
        {
            return tr.getTipoPago();
        }

        [HttpPost]
        public ActionResult postTipoPago([FromBody] TipoPagoRequest request)
        {
            return tr.postTipoPago(request);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult putTipoPago(int id, [FromBody] TipoPagoRequest request)
        {
            return tr.putTipoPago(id,request);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult deleteTipoPago(int id)
        {
            return tr.deleteTipoPago(id);
        }
    }
}
