using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nomina.Interface
{
    public interface IEmpleado
    {
        // metodos que usaremos para los endPoints
        public ActionResult getEmpleado();
        public ActionResult getBuscarEmpleado(string primer_nombre);
        public ActionResult getCountEmpleado();
        public ActionResult getVisualizarEmpleado(int id);
        public ActionResult postEmpleado([FromBody] Request.empleadoRequest request);
        public ActionResult putEmpleado(int id, [FromBody] Request.empleadoRequest request);
        public ActionResult deleteEmpleado(int id);

    }
}
