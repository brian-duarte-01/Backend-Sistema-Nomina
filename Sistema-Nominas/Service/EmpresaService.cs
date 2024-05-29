using Microsoft.AspNetCore.Mvc;
using Sistema_Nominas.Interface;
using Sistema_Nominas.Request;

namespace Sistema_Nominas.Service
{
    public class EmpresaService : ControllerBase, IEmpresa
    {

        // en service separamos toda la logica del controlador de la web api

        // listamos todos los registro por medio del get.

        public ActionResult getEmpresa()
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery = db.Empresas.ToList();
                    return Ok(sqlQuery);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult obtenerEmpresa(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    var sqlQuery =
                        (
                        from sql in db.Empresas
                        where sql.IdEmpresa == id
                        orderby sql.Nombre
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

        public ActionResult postEmpresa([FromBody] EmpresaRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empresa empresa = new Models.Empresa();
                    empresa.Nombre = request.nombre;
                    empresa.Calle = request.calle;
                    empresa.Avenida = request.avenida;
                    empresa.Zona = request.zona;
                    empresa.Telefono = request.telefono;
                    empresa.Nit = request.nit;
                    empresa.Correo = request.correo;
                    db.Empresas.Add(empresa);
                    db.SaveChanges();
                    return Ok("Se envió correctamente");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult putEmpresa(int id, [FromBody] EmpresaRequest request)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empresa empresa = db.Empresas.Find(id);
                    empresa.Nombre = request.nombre;
                    empresa.Calle = request.calle;
                    empresa.Avenida = request.avenida;
                    empresa.Zona = request.zona;
                    empresa.Telefono = request.telefono;
                    empresa.Nit = request.nit;
                    empresa.Correo = request.correo;
                    db.Entry(empresa).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    return Ok("Se edito correctamente!!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult deleteEmpresa(int id)
        {
            try
            {
                using (Models.ModelContext db = new Models.ModelContext())
                {
                    Models.Empresa empresa = db.Empresas.Find(id);
                    db.Empresas.Remove(empresa);
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
