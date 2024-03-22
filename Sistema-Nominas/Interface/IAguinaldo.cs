using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IAguinaldo
    {
        public ActionResult get();
        public ActionResult getBuscar(string empleado);
        public ActionResult getVisualizar(int id);
        public ActionResult post([FromBody] Request.AguinaldoRequest request);
        public ActionResult put(int id, [FromBody] Request.AguinaldoRequest request);
        public ActionResult delete(int id);
    }
}
