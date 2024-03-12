using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface ITipoPago
    {
        public ActionResult getTipoPago();
        public ActionResult getCountTipoPago();
        public ActionResult postTipoPago([FromBody] Request.TipoPagoRequest request);
        public ActionResult putTipoPago(int id, [FromBody] Request.TipoPagoRequest request);
        public ActionResult deleteTipoPago(int id);
    }
}
