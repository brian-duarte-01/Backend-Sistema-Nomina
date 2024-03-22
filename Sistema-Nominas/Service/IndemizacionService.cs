using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class IndemizacionService : ControllerBase,I_indemizacion
    {
       

        public ActionResult get()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Indemizacions.ToList();
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
                    var sqlQuery = (
                        from sql in db.Indemizacions
                        where sql.Empleado == empleado
                        select sql
                        ).ToList();

                    var Sql = db.Indemizacions.ToList();

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
                    var sqlQuery = (
                        from sql in db.Indemizacions
                        where sql.IdIndemizacion == id
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

        public ActionResult post([FromBody] IndemizacionRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Indemizacion indemizacion = new Models.Indemizacion();
                    indemizacion.Empleado = request.empleado;
                    indemizacion.Años = request.años * 365;
                    indemizacion.Meses = request.meses * 30;
                    indemizacion.Dias = indemizacion.Años + indemizacion.Meses;
                    indemizacion.Salario = request.salario;
                    resultado = indemizacion.Salario / 365m;
                    indemizacion.TotalIndemizacion = resultado * indemizacion.Dias;
                    indemizacion.TipoPago = request.tipo_pago;
                    indemizacion.Estado = request.estado;
                    db.Indemizacions.Add(indemizacion);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!"); 
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] IndemizacionRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    Models.Indemizacion indemizacion = db.Indemizacions.Find(id);
                    indemizacion.Empleado = request.empleado;
                    indemizacion.Años = request.años * 365;
                    indemizacion.Meses = request.meses * 30;
                    indemizacion.Dias = indemizacion.Años + indemizacion.Meses;
                    indemizacion.Salario = request.salario;
                    resultado = indemizacion.Salario / 365m;
                    indemizacion.TotalIndemizacion = resultado * indemizacion.Dias;
                    indemizacion.TipoPago = request.tipo_pago;
                    indemizacion.Estado = request.estado;
                    db.Entry(indemizacion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
                    Models.Indemizacion indemizacion = db.Indemizacions.Find(id);
                    db.Indemizacions.Remove(indemizacion);
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
