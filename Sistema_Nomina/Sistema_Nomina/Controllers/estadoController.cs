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

    public class estadoController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/estado
        public IQueryable<estado> Getestado()
        {
            return db.estado;
        }

        // GET: api/estado/5
        [ResponseType(typeof(estado))]
        public IHttpActionResult Getestado(int id)
        {
            estado estado = db.estado.Find(id);
            if (estado == null)
            {
                return NotFound();
            }

            return Ok(estado);
        }

        // PUT: api/estado/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putestado(int id, estado estado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estado.id_status)
            {
                return BadRequest();
            }

            db.Entry(estado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!estadoExists(id))
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

        // POST: api/estado
        [ResponseType(typeof(estado))]
        public IHttpActionResult Postestado(estado estado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.estado.Add(estado);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = estado.id_status }, estado);
        }

        // DELETE: api/estado/5
        [ResponseType(typeof(estado))]
        public IHttpActionResult Deleteestado(int id)
        {
            estado estado = db.estado.Find(id);
            if (estado == null)
            {
                return NotFound();
            }

            db.estado.Remove(estado);
            db.SaveChanges();

            return Ok(estado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool estadoExists(int id)
        {
            return db.estado.Count(e => e.id_status == id) > 0;
        }
    }
}