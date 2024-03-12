using Microsoft.AspNetCore.Mvc;

namespace Sistema_Nominas.Interface
{
    public interface IEmpresa
    {
        public ActionResult getEmpresa();
        public ActionResult postEmpresa([FromBody] Request.EmpresaRequest request);
        public ActionResult putEmpresa(int id, [FromBody] Request.EmpresaRequest request);
        public ActionResult deleteEmpresa(int id);
    }
}
