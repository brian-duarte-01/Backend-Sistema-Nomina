using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface I_indemizacion
    {
        public ActionResult get();
        public ActionResult getBuscar(string empleado);
        public ActionResult getVisualizar(int id);
        public ActionResult post([FromBody] Request.IndemizacionRequest request);
        public ActionResult put(int id, [FromBody] Request.IndemizacionRequest request);
        public ActionResult pagar([FromBody] Request.IndemizacionPagarRequest request);
        public ActionResult delete(int id);
    }
}
