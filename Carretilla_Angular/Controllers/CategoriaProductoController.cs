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
    public class CategoriaProductoController : ApiController
    {
        private CarretillaEntities db = new CarretillaEntities();

        // GET api/CategoriaProducto
        public IQueryable<categoriaProducto> GetcategoriaProducto()
        {
            
            return db.categoriaProducto;
        }

        // GET api/CategoriaProducto/5
        [ResponseType(typeof(categoriaProducto))]
        public IHttpActionResult GetcategoriaProducto(int id)
        {
            categoriaProducto categoriaproducto = db.categoriaProducto.Find(id);
            if (categoriaproducto == null)
            {
                return NotFound();
            }

            return Ok(categoriaproducto);
        }

        // PUT api/CategoriaProducto/5
        public IHttpActionResult PutcategoriaProducto(int id, categoriaProducto categoriaproducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoriaproducto.idCategoriaProducto)
            {
                return BadRequest();
            }

            db.Entry(categoriaproducto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!categoriaProductoExists(id))
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

        // POST api/CategoriaProducto
        [ResponseType(typeof(categoriaProducto))]
        public IHttpActionResult PostcategoriaProducto(categoriaProducto categoriaproducto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.categoriaProducto.Add(categoriaproducto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = categoriaproducto.idCategoriaProducto }, categoriaproducto);
        }

        // DELETE api/CategoriaProducto/5
        [ResponseType(typeof(categoriaProducto))]
        public IHttpActionResult DeletecategoriaProducto(int id)
        {
            categoriaProducto categoriaproducto = db.categoriaProducto.Find(id);
            if (categoriaproducto == null)
            {
                return NotFound();
            }

            db.categoriaProducto.Remove(categoriaproducto);
            db.SaveChanges();

            return Ok(categoriaproducto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool categoriaProductoExists(int id)
        {
            return db.categoriaProducto.Count(e => e.idCategoriaProducto == id) > 0;
        }
    }
}