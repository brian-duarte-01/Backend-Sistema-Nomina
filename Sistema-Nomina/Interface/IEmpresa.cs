using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nomina.Interface
{
    public interface IEmpresa
    {
        public ActionResult getEmpresa();
        public ActionResult postEmpresa([FromBody] Request.empresaRequest request);
        public ActionResult putEmpresa(int id, [FromBody] Request.empresaRequest request);
        public ActionResult deleteEmpresa(int id);
    }
}
