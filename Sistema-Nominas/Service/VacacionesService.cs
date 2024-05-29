using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class VacacionesService : ControllerBase, IVacaciones
    {
        

        public ActionResult get()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var Sql = db.Vacaciones.ToList();
                    return Ok(Sql);
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
                        from sql in db.Vacaciones
                        where sql.Empleado.Contains(empleado)
                        select sql
                        ).ToList();

                    var Sql = db.Vacaciones.ToList();

                    if (empleado == "")
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
                        from sql in db.Vacaciones 
                        where sql.IdVacaciones == id
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

        public ActionResult post([FromBody] VacacionesRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    decimal? resultadoVacaciones = 0;
                    decimal? resultadoDias = 0;
                    Models.Vacacione vacacione = new Models.Vacacione();
                    vacacione.Empleado = request.empleado;
                    vacacione.Meses = request.meses;
                    vacacione.Dias = vacacione.Meses * 30;
                    vacacione.Sueldo = request.sueldo;
                    resultado = vacacione.Sueldo * vacacione.Dias;
                    resultadoVacaciones = resultado / 365;
                    resultadoDias = resultadoVacaciones * 20;
                    vacacione.TotalVacaciones = resultadoDias / 30;
                    vacacione.TipoPago = request.tipo_pago;
                    vacacione.Estado = request.estado;
                    if (vacacione.Dias>=360)
                    { 
                        db.Vacaciones.Add(vacacione);
                        db.SaveChanges();
                        return Ok("Se envio correctamente!!");
                    }
                    else
                    {
                        return Ok("No tiene derecho a vacaciones no tiene mas de un año laborando!!");
                    }

                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] VacacionesRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    decimal? resultado = 0;
                    decimal? resultadoVacaciones = 0;
                    decimal? resultadoDias = 0;
                    Models.Vacacione vacacione = db.Vacaciones.Find(id);
                    vacacione.Empleado = request.empleado;
                    vacacione.Meses = request.meses;
                    vacacione.Dias = vacacione.Meses * 30;
                    vacacione.Sueldo = request.sueldo;
                    resultado = vacacione.Sueldo * vacacione.Dias;
                    resultadoVacaciones = resultado / 365;
                    resultadoDias = resultadoVacaciones * 20;
                    vacacione.TotalVacaciones = resultadoDias / 30;
                    vacacione.TipoPago = request.tipo_pago;
                    vacacione.Estado = request.estado;
                    if (vacacione.Dias >= 365)
                    {
                        db.Entry(vacacione).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        db.SaveChanges();
                        return Ok("Se Edito correctamente!!");
                    }
                    else
                    {
                        return Ok("No tiene derecho a vacaciones no tiene mas de un año laborando!!");
                    }


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
                    Models.Vacacione vacacione = db.Vacaciones.Find(id);
                    db.Vacaciones.Remove(vacacione);
                    db.SaveChanges();
                    return Ok("Se elimino correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult pagar([FromBody] VacacionesPagarRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    foreach (var item in db.Vacaciones)
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
