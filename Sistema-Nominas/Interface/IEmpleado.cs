using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IEmpleado
    {
        // metodos que usaremos para los endPoints
        public ActionResult getEmpleado();
        public ActionResult getBuscarEmpleado(string nit);
        public ActionResult getCountEmpleado();
        public ActionResult getVisualizarEmpleado(int id);
        public ActionResult postEmpleado([FromBody] Request.EmpleadoRequest request);
        public ActionResult putEmpleado(int id, [FromBody] Request.EmpleadoRequest request);
        public ActionResult deleteEmpleado(int id);
    }
}
