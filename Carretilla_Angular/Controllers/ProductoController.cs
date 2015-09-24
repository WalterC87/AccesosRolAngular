using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using Carretilla_Angular.Models;

namespace Carretilla_Angular.Controllers
{
    public class ProductoController : ApiController
    {
        private CarretillaEntities db = new CarretillaEntities();

        // GET api/Producto
        public IQueryable<ProductosDTO> GetProducto()
        {
            var productos = from producto in db.Producto
                            where producto.Estado == true && producto.enPromocion == true
                            select new ProductosDTO()
                            {
                                idProducto = producto.idProducto,
                                Descripcion = producto.Descripcion,
                                PrecioQuetzales = producto.precioQuetzales,
                                PrecioDolares = producto.precioDolares,
                                enPromocion = producto.enPromocion,
                                categoriaProducto = producto.categoriaProducto.Descripcion,
                                slug = producto.slug
                            };
            
            return productos;
        }

        //[Route("api/Producto/getbycategory/{categoryId}")]
        [HttpGet]
        [ActionName("getbycategory")]
        public IQueryable<ProductosDTO> getbycategory(int id)
        {
            var productos = from producto in db.Producto
                            where producto.Estado == true && producto.idCategoriaProducto == id
                            select new ProductosDTO()
                            {
                                idProducto = producto.idProducto,
                                Descripcion = producto.Descripcion,
                                PrecioQuetzales = producto.precioQuetzales,
                                PrecioDolares = producto.precioDolares,
                                enPromocion = producto.enPromocion,
                                categoriaProducto = producto.categoriaProducto.Descripcion,
                                slug = producto.slug
                            };

            return productos;
        }

        // GET api/Producto/5/
        [HttpGet]
        [ActionName("GetProducto")]
        [ResponseType(typeof(DetalleProductoDTO))]
        public IHttpActionResult GetProducto(int id)
        {
            var producto = db.Producto.Include(p => p.idCategoriaProducto).Select(p =>
                    new DetalleProductoDTO()
                    {
                        idProducto = p.idProducto,
                        Descripcion = p.Descripcion,
                        PrecioQuetzales = p.precioQuetzales,
                        PrecioDolares = p.precioDolares,
                        Existencia = p.Existencia,
                        enPromocion = p.enPromocion,
                        Estado = p.Estado,
                        categoriaProducto = p.categoriaProducto.Descripcion,
                        slug = p.slug
                    }).SingleOrDefault(p => p.idProducto == id);
            
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // PUT api/Producto/5
        public IHttpActionResult PutProducto(int id, Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.idProducto)
            {
                return BadRequest();
            }

            db.Entry(producto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
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

        // POST api/Producto
        [ResponseType(typeof(Producto))]
        public IHttpActionResult PostProducto(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Producto.Add(producto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = producto.idProducto }, producto);
        }

        // DELETE api/Producto/5
        [ResponseType(typeof(Producto))]
        public IHttpActionResult DeleteProducto(int id)
        {
            Producto producto = db.Producto.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            db.Producto.Remove(producto);
            db.SaveChanges();

            return Ok(producto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductoExists(int id)
        {
            return db.Producto.Count(e => e.idProducto == id) > 0;
        }
    }
}