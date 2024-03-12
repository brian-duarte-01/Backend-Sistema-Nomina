using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Interface
{
    public interface INota
    {
        public ActionResult getNota();
        public ActionResult postNota([FromBody] Request.NotaRequest request);
        public ActionResult putNota(int id, [FromBody] Request.NotaRequest request);
        public ActionResult deleteNota(int id);
    }
}
