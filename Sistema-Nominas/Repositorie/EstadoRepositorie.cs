using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class EstadoRepositorie
    {

        public IEstado iestado;
        public EstadoRepositorie(IEstado _iestado)
        {
            this.iestado = _iestado;
        }

        public ActionResult getCountEstado()
        {
            return this.iestado.getCountEstado();
        }

        public ActionResult getEstado()
        {
            return this.iestado.getEstado();    
        }

        public ActionResult obtenerEstado(int id)
        {
            return this.iestado.obtenerEstado(id);
        }

        public ActionResult postEstado([FromBody] EstadoRequest request)
        {
            return this.iestado.postEstado(request);
        }

        public ActionResult putEstado(int id, [FromBody] EstadoRequest request)
        {
            return this.iestado.putEstado(id, request);
        }

        public ActionResult deleteEstado(int id)
        {
            return this.iestado.deleteEstado(id);
        }

       
    }
}
