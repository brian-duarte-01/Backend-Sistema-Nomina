using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IPrestaciones
    {
        public ActionResult get();
        public ActionResult getBuscar(string empleado);
        public ActionResult getVisualizar(int id);
        public ActionResult post([FromBody] Request.PagosRequest request);
        public ActionResult put(int id, [FromBody] Request.PagosRequest request);
        public ActionResult pagar([FromBody] Request.PagoPagarRequest request);
        public ActionResult delete(int id);
    }
}
