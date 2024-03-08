using Microsoft.AspNetCore.Mvc;
using Sistema_Nomina.Interface;
using Sistema_Nomina.Request;

namespace Sistema_Nomina.Repositorie
{
    public class EmpleadoRepositorie : IEmpleado
    {
        public IEmpleado iempleado;
        public EmpleadoRepositorie(IEmpleado _iempleado)
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

        public ActionResult postEmpleado([FromBody] empleadoRequest request)
        {
            return this.iempleado.postEmpleado(request);
        }

        public ActionResult putEmpleado(int id, [FromBody] empleadoRequest request)
        {
            return this.iempleado.putEmpleado(id, request); 
        }
        public ActionResult deleteEmpleado(int id)
        {
            return this.iempleado.deleteEmpleado(id);
        }
    }
}
