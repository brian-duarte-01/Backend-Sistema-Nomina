using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Repositorie
{
    public class AguinaldoRepositorie: IAguinaldo
    {
        public IAguinaldo iaguinaldo;

        public AguinaldoRepositorie(IAguinaldo _iaguinaldo)
        {
            this.iaguinaldo = _iaguinaldo;
        }

       
        public ActionResult get()
        {
            return this.iaguinaldo.get();
        }

        public ActionResult getBuscar(string empleado)
        {
            return this.iaguinaldo.getBuscar(empleado);
        }

        public ActionResult getVisualizar(int id)
        {
            return this.iaguinaldo.getVisualizar(id);
        }

        public ActionResult post([FromBody] AguinaldoRequest request)
        {
            return this.iaguinaldo.post(request);
        }

        public ActionResult put(int id, [FromBody] AguinaldoRequest request)
        {
            return this.iaguinaldo.put(id, request);
        }

        public ActionResult delete(int id)
        {
            return this.iaguinaldo.delete(id);
        }

        public ActionResult pagar([FromBody] AguinaldoPagarRequest request)
        {
            return this.iaguinaldo.pagar(request);
        }
    }
}
