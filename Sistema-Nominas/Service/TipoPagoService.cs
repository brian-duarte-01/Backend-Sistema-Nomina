using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class TipoPagoService : ControllerBase, ITipoPago
    {
       

        public ActionResult getCountTipoPago()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.TipoPagos.Count();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getTipoPago()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.TipoPagos.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult obtenerTipoPago(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.TipoPagos
                        where sql.IdTipoPago == id
                        orderby sql.TipoPago1
                        select sql
                        ).ToList();
                    return Ok(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult postTipoPago([FromBody] TipoPagoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.TipoPago tipo = new Models.TipoPago();
                    tipo.TipoPago1 = request.tipo_pago;
                    db.TipoPagos.Add(tipo);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult putTipoPago(int id, [FromBody] TipoPagoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.TipoPago tipo = db.TipoPagos.Find(id);
                    tipo.TipoPago1 = request.tipo_pago;
                    db.Entry(tipo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public ActionResult deleteTipoPago(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.TipoPago tipo = db.TipoPagos.Find(id);
                    db.TipoPagos.Remove(tipo);
                    db.SaveChanges();
                    return Ok("Se elimino correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
