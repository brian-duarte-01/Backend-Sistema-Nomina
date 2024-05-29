using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class VacacionesRRepositorie
    {

        public IVacaciones ivaciones;

        public VacacionesRRepositorie(IVacaciones _ivacaciones)
        {
            this.ivaciones = _ivacaciones;
        }

        public ActionResult get()
        {
            return this.ivaciones.get();
        }

        public ActionResult getBuscar(string empleado)
        {
            return this.ivaciones.getBuscar(empleado);
        }

        public ActionResult getVisualizar(int id)
        {
            return this.ivaciones.getVisualizar(id);
        }

        public ActionResult post([FromBody] VacacionesRequest request)
        {
            return this.ivaciones.post(request);
        }

        public ActionResult put(int id, [FromBody] VacacionesRequest request)
        {
            return this.ivaciones.put(id, request);
        }

        public ActionResult delete(int id)
        {
            return this.ivaciones.delete(id);
        }

        public ActionResult pagar([FromBody] VacacionesPagarRequest request)
        {
            return this.ivaciones.pagar(request);
        }
    }
}
