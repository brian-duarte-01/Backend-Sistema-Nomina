using Microsoft.AspNetCore.Mvc;
using WebApplication2.Interface;
using WebApplication2.Request;

namespace WebApplication2.Repositorie
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
