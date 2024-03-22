using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class AguinaldoService : ControllerBase, IAguinaldo
    {
        
        public ActionResult get()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Aguinaldos.ToList();
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
                        from sql in db.Aguinaldos
                        where sql.Empleado == empleado
                        select sql
                        ).ToList();

                    var Sql = db.Aguinaldos.ToList();

                    if (empleado=="")
                    {
                        return Ok(Sql);
                    }
                    else if (sqlQuery.Any())
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

        public ActionResult getVisualizar(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Aguinaldos
                        where sql.IdAguinaldo == id
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

        public ActionResult post([FromBody] AguinaldoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Aguinaldo aguinaldo = new Models.Aguinaldo();
                    aguinaldo.Empleado = request.empleado;
                    aguinaldo.Meses = request.meses;
                    aguinaldo.Dias = aguinaldo.Meses * 30;
                    aguinaldo.Salario = request.salario;
                    resultado = aguinaldo.Salario * aguinaldo.Dias;
                    aguinaldo.TotalAguinaldo = resultado / 365;
                    aguinaldo.TipoPago = request.tipo_pago;
                    aguinaldo.Estado = request.estado;
                    db.Aguinaldos.Add(aguinaldo);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] AguinaldoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Aguinaldo aguinaldo = db.Aguinaldos.Find(id);
                    aguinaldo.Empleado = request.empleado;
                    aguinaldo.Meses = request.meses;
                    aguinaldo.Dias = aguinaldo.Meses * 30;
                    aguinaldo.Salario = request.salario;
                    resultado = aguinaldo.Salario * aguinaldo.Dias;
                    aguinaldo.TotalAguinaldo = resultado / 365;
                    aguinaldo.TipoPago = request.tipo_pago;
                    aguinaldo.Estado = request.estado;
                    db.Entry(aguinaldo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                    Models.Aguinaldo aguinaldo = db.Aguinaldos.Find(id);
                    db.Aguinaldos.Remove(aguinaldo);
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
