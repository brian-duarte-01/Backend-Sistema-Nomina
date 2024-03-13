using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IEstado
    {
        public ActionResult getEstado();
        public ActionResult getCountEstado();
        public ActionResult postEstado([FromBody] Request.EstadoRequest request);
        public ActionResult putEstado(int id, [FromBody] Request.EstadoRequest request);
        public ActionResult deleteEstado(int id);
    }
}
