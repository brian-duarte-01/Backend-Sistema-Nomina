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

    public class pagosController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/pagos
        public IQueryable<pagos> Getpagos()
        {
            return db.pagos;
        }

        // GET: api/pagos/5
        [ResponseType(typeof(pagos))]
        public IHttpActionResult Getpagos(int id)
        {
            pagos pagos = db.pagos.Find(id);
            if (pagos == null)
            {
                return NotFound();
            }

            return Ok(pagos);
        }

        // PUT: api/pagos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpagos(int id, pagos pagos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pagos.id_pagos)
            {
                return BadRequest();
            }

            db.Entry(pagos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pagosExists(id))
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

        // POST: api/pagos
        [ResponseType(typeof(pagos))]
        public IHttpActionResult Postpagos(pagos pagos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.pagos.Add(pagos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pagos.id_pagos }, pagos);
        }

        // DELETE: api/pagos/5
        [ResponseType(typeof(pagos))]
        public IHttpActionResult Deletepagos(int id)
        {
            pagos pagos = db.pagos.Find(id);
            if (pagos == null)
            {
                return NotFound();
            }

            db.pagos.Remove(pagos);
            db.SaveChanges();

            return Ok(pagos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool pagosExists(int id)
        {
            return db.pagos.Count(e => e.id_pagos == id) > 0;
        }
    }
}