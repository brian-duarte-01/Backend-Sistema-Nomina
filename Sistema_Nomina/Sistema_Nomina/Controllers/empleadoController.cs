using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Sistema_Nomina.Models;
using System.Web.Http.Cors;

namespace Sistema_Nomina.Controllers
{


    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")] 


    public class empleadoController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/empleado
        public IQueryable<empleado> Getempleado()
        {
            return db.empleado;
        }

        // GET: api/empleado/5
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Getempleado(int id)
        {
            empleado empleado = db.empleado.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }

            return Ok(empleado);
        }

        // PUT: api/empleado/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putempleado(int id, empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empleado.id_empleado)
            {
                return BadRequest();
            }

            db.Entry(empleado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!empleadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/empleado
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Postempleado(empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.empleado.Add(empleado);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empleado.id_empleado }, empleado);
        }

        // DELETE: api/empleado/5
        [ResponseType(typeof(empleado))]
        public IHttpActionResult Deleteempleado(int id)
        {
            empleado empleado = db.empleado.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }

            db.empleado.Remove(empleado);
            db.SaveChanges();

            return Ok(empleado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool empleadoExists(int id)
        {
            return db.empleado.Count(e => e.id_empleado == id) > 0;
        }
    }
}