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

    public class empresaController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/empresa
        public IQueryable<empresa> Getempresa()
        {
            return db.empresa;
        }

        // GET: api/empresa/5
        [ResponseType(typeof(empresa))]
        public IHttpActionResult Getempresa(int id)
        {
            empresa empresa = db.empresa.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            return Ok(empresa);
        }

        // PUT: api/empresa/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putempresa(int id, empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != empresa.id_empresa)
            {
                return BadRequest();
            }

            db.Entry(empresa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!empresaExists(id))
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

        // POST: api/empresa
        [ResponseType(typeof(empresa))]
        public IHttpActionResult Postempresa(empresa empresa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.empresa.Add(empresa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = empresa.id_empresa }, empresa);
        }

        // DELETE: api/empresa/5
        [ResponseType(typeof(empresa))]
        public IHttpActionResult Deleteempresa(int id)
        {
            empresa empresa = db.empresa.Find(id);
            if (empresa == null)
            {
                return NotFound();
            }

            db.empresa.Remove(empresa);
            db.SaveChanges();

            return Ok(empresa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool empresaExists(int id)
        {
            return db.empresa.Count(e => e.id_empresa == id) > 0;
        }
    }
}