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
    public class CarretillaController : ApiController
    {
        private CarretillaEntities db = new CarretillaEntities();

        // GET api/Carretilla
        public IQueryable<Carretilla> GetCarretilla()
        {
            return db.Carretilla;
        }

        // GET api/Carretilla/5
        [ResponseType(typeof(Carretilla))]
        public IHttpActionResult GetCarretilla(int id)
        {
            Carretilla carretilla = db.Carretilla.Find(id);
            if (carretilla == null)
            {
                return NotFound();
            }

            return Ok(carretilla);
        }

        // PUT api/Carretilla/5
        public IHttpActionResult PutCarretilla(int id, Carretilla carretilla)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carretilla.idCarretilla)
            {
                return BadRequest();
            }

            db.Entry(carretilla).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarretillaExists(id))
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

        // POST api/Carretilla
        [ResponseType(typeof(Carretilla))]
        public IHttpActionResult PostCarretilla(Carretilla carretilla)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carretilla.Add(carretilla);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carretilla.idCarretilla }, carretilla);
        }

        // DELETE api/Carretilla/5
        [ResponseType(typeof(Carretilla))]
        public IHttpActionResult DeleteCarretilla(int id)
        {
            Carretilla carretilla = db.Carretilla.Find(id);
            if (carretilla == null)
            {
                return NotFound();
            }

            db.Carretilla.Remove(carretilla);
            db.SaveChanges();

            return Ok(carretilla);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarretillaExists(int id)
        {
            return db.Carretilla.Count(e => e.idCarretilla == id) > 0;
        }
    }
}