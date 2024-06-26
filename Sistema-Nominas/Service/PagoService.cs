﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;
using System.Data.SqlTypes;

namespace Sistema_Nominas.Service
{
    public class PagoService : ControllerBase, IPrestaciones
    {
        

        public ActionResult get()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sql = db.Pagos.ToList();
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
                    // consulta linq donde se listada por nombre
                    var sqlQuery =
                        (
                        from sql in db.Pagos
                        where sql.Empleado == empleado
                        select sql
                        ).ToList();

                    // se listara todos los registros
                    var Sql = db.Pagos.ToList();

                    if (empleado=="")
                    {
                        return Ok(Sql);
                    }
                    else if(sqlQuery.Any())
                    {
                        return Ok(sqlQuery);
                    }
                    else
                    {
                        return Ok("No se encontre el empleado!!");
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
                        from sql in db.Pagos
                        where sql.IdPagos == id
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

        public ActionResult post([FromBody] PagosRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Pago pago = new Models.Pago();
                    pago.Empleado = request.empleado;
                    pago.Salario = request.salario;
                    pago.Bonificacion = request.bonificacion;
                    pago.IgssEmpleado = pago.Salario * 0.0483m;
                    pago.SalarioDevengado = pago.Salario + pago.Bonificacion - pago.IgssEmpleado;
                    pago.CuotaPatronal = pago.Salario * 0.1267m;
                    pago.TotalPatronal = pago.Salario + pago.Bonificacion + pago.CuotaPatronal;
                    pago.TotalEmpleado = pago.IgssEmpleado + pago.CuotaPatronal + pago.SalarioDevengado;
                    pago.SalarioQuincenal = pago.Salario /2;
                    pago.BonificacionQuincenal = pago.Bonificacion /2;
                    pago.IgssEmpleadoQuincenal = pago.IgssEmpleado / 2;
                    pago.SalarioDevengadoQuincenal = pago.SalarioQuincenal + pago.BonificacionQuincenal - pago.IgssEmpleadoQuincenal;
                    pago.IgssPatronalQuincenal = pago.CuotaPatronal /2;
                    pago.TotalEmpleadoQuincenal = pago.IgssEmpleadoQuincenal + pago.IgssPatronalQuincenal + pago.SalarioDevengadoQuincenal;
                    pago.TotalPatronalQuincenal = pago.SalarioQuincenal + pago.BonificacionQuincenal + pago.IgssPatronalQuincenal;
                    pago.TipoPago = request.tipo_pago;
                    pago.Estado = request.estado;
                    db.Pagos.Add(pago);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult put(int id, [FromBody] PagosRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Pago pago = db.Pagos.Find(id);
                    pago.Empleado = request.empleado;
                    pago.Salario = request.salario;
                    pago.Bonificacion = request.bonificacion;
                    pago.IgssEmpleado = pago.Salario * 0.0483m;
                    pago.SalarioDevengado = pago.Salario + pago.Bonificacion - pago.IgssEmpleado;
                    pago.CuotaPatronal = pago.Salario * 0.1267m;
                    pago.TotalPatronal = pago.Salario + pago.Bonificacion + pago.CuotaPatronal;
                    pago.TotalEmpleado = pago.IgssEmpleado + pago.CuotaPatronal + pago.SalarioDevengado;
                    pago.SalarioQuincenal = pago.Salario / 2;
                    pago.BonificacionQuincenal = pago.Bonificacion / 2;
                    pago.IgssEmpleadoQuincenal = pago.IgssEmpleado / 2;
                    pago.SalarioDevengadoQuincenal = pago.SalarioQuincenal + pago.BonificacionQuincenal - pago.IgssEmpleadoQuincenal;
                    pago.IgssPatronalQuincenal = pago.CuotaPatronal / 2;
                    pago.TotalEmpleadoQuincenal = pago.IgssEmpleadoQuincenal + pago.IgssPatronalQuincenal + pago.SalarioDevengadoQuincenal;
                    pago.TotalPatronalQuincenal = pago.SalarioQuincenal + pago.BonificacionQuincenal + pago.IgssPatronalQuincenal;
                    pago.TipoPago = request.tipo_pago;
                    pago.Estado = request.estado;
                    db.Entry(pago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult pagar([FromBody] PagoPagarRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var pagos = db.Pagos.ToList();

                    // Actualizar el estado de cada registro
                    foreach (var pago in pagos)
                    {
                        pago.Estado = request.estado;
                        db.Entry(pago).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }

                    // Guardar cambios en la base de datos
                    db.SaveChanges();
                    return Ok("Se realizo correctamente!!");
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
                    Models.Pago pago = db.Pagos.Find(id);
                    db.Pagos.Remove(pago);
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
