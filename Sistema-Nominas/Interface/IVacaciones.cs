using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IVacaciones
    {
        public ActionResult get();
        public ActionResult getBuscar(string empleado);
        public ActionResult getVisualizar(int id);
        public ActionResult post([FromBody] Request.VacacionesRequest request);
        public ActionResult put(int id, [FromBody] Request.VacacionesRequest request);
        public ActionResult pagar([FromBody] Request.VacacionesPagarRequest request);
        public ActionResult delete(int id);
    }
}
