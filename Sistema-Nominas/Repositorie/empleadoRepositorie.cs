using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class empleadoRepositorie
    {
        public IEmpleado iempleado;
        public empleadoRepositorie(IEmpleado _iempleado)
        {
            this.iempleado = _iempleado;
        }

        public ActionResult getBuscarEmpleado(string primer_nombre)
        {
            return this.iempleado.getBuscarEmpleado(primer_nombre);
        }

        public ActionResult getCountEmpleado()
        {
            return this.iempleado.getCountEmpleado();
        }

        public ActionResult getEmpleado()
        {
            return this.iempleado.getEmpleado();
        }

        public ActionResult getVisualizarEmpleado(int id)
        {
            return this.iempleado.getVisualizarEmpleado(id);
        }

        public ActionResult postEmpleado([FromBody] EmpleadoRequest request)
        {
            return this.iempleado.postEmpleado(request);
        }

        public ActionResult putEmpleado(int id, [FromBody] EmpleadoRequest request)
        {
            return this.iempleado.putEmpleado(id, request);
        }
        public ActionResult deleteEmpleado(int id)
        {
            return this.iempleado.deleteEmpleado(id);
        }
    }
}
