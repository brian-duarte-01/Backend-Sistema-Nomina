using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class EstadoService : ControllerBase, IEstado
    {
       

        public ActionResult getCountEstado()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Estados.Count();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getEstado()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Estados.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult obtenerEstado(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Estados
                        where sql.IdStatus == id
                        orderby sql.Status 
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

        public ActionResult postEstado([FromBody] EstadoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Estado estado = new Models.Estado();
                    estado.Status = request.status;
                    db.Estados.Add(estado);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult putEstado(int id, [FromBody] EstadoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Estado estado = db.Estados.Find(id);
                    estado.Status = request.status;
                    db.Entry(estado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult deleteEstado(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Estado estado = db.Estados.Find(id);
                    db.Estados.Remove(estado);
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
