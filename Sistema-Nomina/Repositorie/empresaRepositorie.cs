using Microsoft.AspNetCore.Mvc;
using Sistema_Nomina.Interface;
using Sistema_Nomina.Request;

namespace Sistema_Nomina.Repositorie
{
    public class empresaRepositorie 
    {
        // utilizamos el patron de diseño inyeccion de depencia

        public IEmpresa iempresa;
        public empresaRepositorie(IEmpresa _empresa)
        {
            this.iempresa = _empresa;
        }

        public ActionResult getEmpresa()
        {
            return this.iempresa.getEmpresa();
        }

        public ActionResult postEmpresa([FromBody] empresaRequest request)
        {
            return this.iempresa.postEmpresa(request);
        }

        public ActionResult putEmpresa(int id, [FromBody] empresaRequest request)
        {
            return this.iempresa.putEmpresa(id, request);
        }

        public ActionResult deleteEmpresa(int id)
        {
            return this.iempresa.deleteEmpresa(id);
        }
    }
}
