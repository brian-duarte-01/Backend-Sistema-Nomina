using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class Bono14Repositorie 
    {


        public IBono14 ibono;

        public Bono14Repositorie(IBono14 _ibono)
        {
            this.ibono = _ibono;
        }

        public ActionResult get()
        {
            return this.ibono.get();
        }

        public ActionResult getBuscar(string empleado)
        {
            return this.ibono.getBuscar(empleado);
        }

        public ActionResult getVisualizar(int id)
        {
            return this.ibono.getVisualizar(id);
        }

        public ActionResult post([FromBody] Bono14Request request)
        {
            return this.ibono.post(request);
        }

        public ActionResult put(int id, [FromBody] Bono14Request request)
        {
            return this.ibono.put(id,request);
        }

        public ActionResult delete(int id)
        {
            return this.ibono.delete(id);
        }
    }
}
