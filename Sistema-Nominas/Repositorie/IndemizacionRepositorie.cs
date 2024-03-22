using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class IndemizacionRepositorie
    {
        public I_indemizacion indemizacion;

        public IndemizacionRepositorie(I_indemizacion _Indemizacion)
        {
            this.indemizacion = _Indemizacion;
        }

        public ActionResult get()
        {
            return this.indemizacion.get();
        }

        public ActionResult getBuscar(string empleado)
        {
            return this.indemizacion.getBuscar(empleado);
        }

        public ActionResult getVisualizar(int id)
        {
            return this.indemizacion.getVisualizar(id);
        }

        public ActionResult post([FromBody] IndemizacionRequest request)
        {
            return this.indemizacion.post(request);
        }

        public ActionResult put(int id, [FromBody] IndemizacionRequest request)
        {
            return this.indemizacion.put(id,request);
        }

        public ActionResult delete(int id)
        {
            return this.indemizacion.delete(id);
        }
    }
}
