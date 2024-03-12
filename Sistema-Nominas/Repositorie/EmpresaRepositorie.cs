using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class EmpresaRepositorie 
    {

        // utilizamos el patron de diseño inyeccion de depencia

        public IEmpresa iempresa;

        public EmpresaRepositorie(IEmpresa _iempresa)
        {
            this.iempresa = _iempresa;
        }

        public ActionResult getEmpresa()
        {
            return this.iempresa.getEmpresa();
        }

        public ActionResult postEmpresa([FromBody] EmpresaRequest request)
        {
            return this.iempresa.postEmpresa(request);
        }

        public ActionResult putEmpresa(int id, [FromBody] EmpresaRequest request)
        {
            return this.iempresa.putEmpresa(id, request);
        }

        public ActionResult deleteEmpresa(int id)
        {
            return this.iempresa.deleteEmpresa(id);
        }
    }
}
