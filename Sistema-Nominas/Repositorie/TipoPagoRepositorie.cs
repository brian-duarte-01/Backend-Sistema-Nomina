using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class TipoPagoRepositorie 
    {

        public ITipoPago itipo;

        public TipoPagoRepositorie(ITipoPago _itipo)
        {
            this.itipo = _itipo;
        }

        public ActionResult getCountTipoPago()
        {
            return this.itipo.getCountTipoPago();
        }

        public ActionResult getTipoPago()
        {
            return this.itipo.getTipoPago();
        }

        public ActionResult postTipoPago([FromBody] TipoPagoRequest request)
        {
            return this.itipo.postTipoPago(request);
        }

        public ActionResult putTipoPago(int id, [FromBody] TipoPagoRequest request)
        {
            return this.itipo.putTipoPago(id, request);
        }

        public ActionResult deleteTipoPago(int id)
        {
            return this.itipo.deleteTipoPago(id);
        }

    }
}
