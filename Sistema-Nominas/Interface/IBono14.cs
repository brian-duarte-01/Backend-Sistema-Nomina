using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IBono14
    {
        public ActionResult get();
        public ActionResult getBuscar(string empleado);
        public ActionResult getVisualizar(int id);
        public ActionResult post([FromBody] Request.Bono14Request request);
        public ActionResult put(int id, [FromBody] Request.Bono14Request request);
        public ActionResult pagar([FromBody] Request.Bono14PagarRequest request);
        public ActionResult delete(int id);
    }
}
