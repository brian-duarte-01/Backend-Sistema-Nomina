using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class empleadoService:ControllerBase,IEmpleado
    {


        // endPoint para buscar el empleado

        public ActionResult getBuscarEmpleado(string nit)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {


                    var sqlQuery = (
                        from sql in db.Empleados
                        where sql.Nit == nit
                        select sql
                        ).ToList();

                    if (nit == "")
                    {
                        var sqlListar = db.Empleados.ToList();
                        return Ok(sqlListar);
                    }
                    else if(sqlQuery.Any())
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

        //EndPoint para contar cuantos empleados existen.
        public ActionResult getCountEmpleado()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery = db.Empleados.Count();
                    return Ok(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //EndPoint para listar todos los empleados
        public ActionResult getEmpleado()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery = db.Empleados.ToList();
                    return Ok(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // EndPoint para visulizar los datos tipo factura.
        public ActionResult getVisualizarEmpleado(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Empleados
                        where sql.IdEmpleado == id
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

        //Post para ingresar los datos a la base de datos
        public ActionResult postEmpleado([FromBody] EmpleadoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empleado empleado = new Models.Empleado();
                    empleado.PrimerNombre = request.primer_nombre;
                    empleado.SegundoNombre = request.segundo_nombre;
                    empleado.PrimerApellido = request.primer_apellido;
                    empleado.SegundoApellido = request.segundo_apellido;
                    empleado.Nit = request.nit;
                    empleado.Calle = request.calle;
                    empleado.Avenida = request.avenida;
                    empleado.Zona = request.zona;
                    empleado.Telefono = request.telefono;
                    empleado.Correo = request.correo;
                    empleado.Empresa = request.empresa;
                    db.Empleados.Add(empleado);
                    db.SaveChanges();
                    return Ok("Se envio correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Peticion Put para actualizar al empleado
        public ActionResult putEmpleado(int id, [FromBody] EmpleadoRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empleado empleado = db.Empleados.Find(id);
                    empleado.PrimerNombre = request.primer_nombre;
                    empleado.SegundoNombre = request.segundo_nombre;
                    empleado.PrimerApellido = request.primer_apellido;
                    empleado.SegundoApellido = request.segundo_apellido;
                    empleado.Nit = request.nit;
                    empleado.Calle = request.calle;
                    empleado.Avenida = request.avenida;
                    empleado.Zona = request.zona;
                    empleado.Telefono = request.telefono;
                    empleado.Correo = request.correo;
                    empleado.Empresa = request.empresa;
                    db.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Peticion Delete para eliminar el empleado
        public ActionResult deleteEmpleado(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empleado empleado = db.Empleados.Find(id);
                    db.Empleados.Remove(empleado);
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
