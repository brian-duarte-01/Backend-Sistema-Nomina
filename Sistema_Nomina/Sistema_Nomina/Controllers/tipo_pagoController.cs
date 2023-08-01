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

    public class tipo_pagoController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/tipo_pago
        public IQueryable<tipo_pago> Gettipo_pago()
        {
            return db.tipo_pago;
        }

        // GET: api/tipo_pago/5
        [ResponseType(typeof(tipo_pago))]
        public IHttpActionResult Gettipo_pago(int id)
        {
            tipo_pago tipo_pago = db.tipo_pago.Find(id);
            if (tipo_pago == null)
            {
                return NotFound();
            }

            return Ok(tipo_pago);
        }

        // PUT: api/tipo_pago/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttipo_pago(int id, tipo_pago tipo_pago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_pago.id_tipo_pago)
            {
                return BadRequest();
            }

            db.Entry(tipo_pago).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tipo_pagoExists(id))
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

        // POST: api/tipo_pago
        [ResponseType(typeof(tipo_pago))]
        public IHttpActionResult Posttipo_pago(tipo_pago tipo_pago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tipo_pago.Add(tipo_pago);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipo_pago.id_tipo_pago }, tipo_pago);
        }

        // DELETE: api/tipo_pago/5
        [ResponseType(typeof(tipo_pago))]
        public IHttpActionResult Deletetipo_pago(int id)
        {
            tipo_pago tipo_pago = db.tipo_pago.Find(id);
            if (tipo_pago == null)
            {
                return NotFound();
            }

            db.tipo_pago.Remove(tipo_pago);
            db.SaveChanges();

            return Ok(tipo_pago);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tipo_pagoExists(int id)
        {
            return db.tipo_pago.Count(e => e.id_tipo_pago == id) > 0;
        }
    }
}