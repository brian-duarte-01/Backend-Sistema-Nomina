using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Request;

namespace WebApplication1.Repositorie
{
    public class NotaRepositorie 
    {

        public INota inota;

        public NotaRepositorie(INota _inota)
        {
            this.inota = _inota;
        }

        public ActionResult getNota()
        {
            return this.inota.getNota();
        }

        public ActionResult postNota([FromBody] NotaRequest request)
        {
            return this.inota.postNota(request);
        }

        public ActionResult putNota(int id, [FromBody] NotaRequest request)
        {
            return this.inota.putNota(id, request);
        }

        public ActionResult deleteNota(int id)
        {
            return this.inota.deleteNota(id);   
        }
    }
}
