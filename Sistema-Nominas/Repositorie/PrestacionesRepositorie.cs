using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class PrestacionesRepositorie
    {
        public IPrestaciones iprestaciones;

       public PrestacionesRepositorie(IPrestaciones _iprestaciones)
        {
            this.iprestaciones = _iprestaciones;
        }

        public ActionResult get()
        {
            return this.iprestaciones.get();
        }

        public ActionResult getBuscar(string empleado)
        {
            return this.iprestaciones.getBuscar(empleado);
        }

        public ActionResult getVisualizar(int id)
        {
            return this.iprestaciones.getVisualizar(id);
        }

        public ActionResult post([FromBody] PagosRequest request)
        {
            return this.iprestaciones.post(request);
        }

        public ActionResult put(int id, [FromBody] PagosRequest request)
        {
            return this.iprestaciones.put(id, request);
        }

        public ActionResult pagar([FromBody] PagoPagarRequest request)
        {
          return  this.iprestaciones.pagar(request);
        }

        public ActionResult delete(int id)
        {
            return this.iprestaciones.delete(id);
        }

        
    }
}
