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
using Carretilla_Angular.Models;

namespace Carretilla_Angular.Controllers
{
    public class DetalleCarretillaController : ApiController
    {
        private CarretillaEntities db = new CarretillaEntities();

        // GET api/DetalleCarretilla
        public IQueryable<detalleCarretilla> GetdetalleCarretilla()
        {
            return db.detalleCarretilla;
        }

        // GET api/DetalleCarretilla/5
        [ResponseType(typeof(detalleCarretilla))]
        public IHttpActionResult GetdetalleCarretilla(int id)
        {
            detalleCarretilla detallecarretilla = db.detalleCarretilla.Find(id);
            if (detallecarretilla == null)
            {
                return NotFound();
            }

            return Ok(detallecarretilla);
        }

        // PUT api/DetalleCarretilla/5
        public IHttpActionResult PutdetalleCarretilla(int id, detalleCarretilla detallecarretilla)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detallecarretilla.idDetalleCarretilla)
            {
                return BadRequest();
            }

            db.Entry(detallecarretilla).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalleCarretillaExists(id))
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

        // POST api/DetalleCarretilla
        [ResponseType(typeof(detalleCarretilla))]
        public IHttpActionResult PostdetalleCarretilla(detalleCarretilla detallecarretilla)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.detalleCarretilla.Add(detallecarretilla);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = detallecarretilla.idDetalleCarretilla }, detallecarretilla);
        }

        // DELETE api/DetalleCarretilla/5
        [ResponseType(typeof(detalleCarretilla))]
        public IHttpActionResult DeletedetalleCarretilla(int id)
        {
            detalleCarretilla detallecarretilla = db.detalleCarretilla.Find(id);
            if (detallecarretilla == null)
            {
                return NotFound();
            }

            db.detalleCarretilla.Remove(detallecarretilla);
            db.SaveChanges();

            return Ok(detallecarretilla);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool detalleCarretillaExists(int id)
        {
            return db.detalleCarretilla.Count(e => e.idDetalleCarretilla == id) > 0;
        }
    }
}