using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class Bono14Service : ControllerBase, IBono14
    {
      

        public ActionResult get()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Bono14s.ToList();
                    return Ok(sql);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getBuscar(string empleado)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Bono14s
                        where sql.Empleado.Contains(empleado)
                        select sql
                        ).ToList();

                    var Sql = db.Bono14s.ToList();

                    if (empleado =="")
                    {
                        return Ok(Sql);
                    }
                    else if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        var respuesta = "No se encontró el usuario!!";
                        return Ok(respuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult getVisualizar(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Bono14s
                        where sql.IdBono14 == id
                        select sql
                        ).ToList();

                    if (sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontró el empleado!!");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult post([FromBody] Bono14Request request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Bono14 bono = new Models.Bono14();
                    bono.Empleado = request.empleado;
                    bono.Meses = request.meses;
                    bono.Dias = bono.Meses * 30;
                    bono.Salario = request.salario;
                    resultado = bono.Salario / 365;
                    bono.TotalBono14 = resultado * bono.Dias;
                    bono.TipoPago = request.tipo_pago;
                    bono.Estado = request.estado;
                    db.Bono14s.Add(bono);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] Bono14Request request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Bono14 bono = db.Bono14s.Find(id);
                    bono.Empleado = request.empleado;
                    bono.Meses = request.meses;
                    bono.Dias = bono.Meses * 30;
                    bono.Salario = request.salario;
                    resultado = bono.Salario / 365;
                    bono.TotalBono14 = resultado * bono.Dias;
                    bono.TipoPago = request.tipo_pago;
                    bono.Estado = request.estado;
                    db.Entry(bono).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult delete(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Bono14 bono = db.Bono14s.Find(id);
                    db.Bono14s.Remove(bono);
                    db.SaveChanges();
                    return Ok("Se elimino correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        public ActionResult pagar([FromBody] Bono14PagarRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    foreach (var item in db.Bono14s)
                    {
                        item.Estado = request.estado;
                        db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    db.SaveChanges();
                    return Ok("Se realizo correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
