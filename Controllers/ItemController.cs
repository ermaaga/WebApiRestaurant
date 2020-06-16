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
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ItemController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Items
        public IQueryable<Item> GetItem()
        {
            return db.Item;
        }

        #region old code
        //// GET: api/Items/5
        //[ResponseType(typeof(Item))]
        //public IHttpActionResult GetItem(int id)
        //{
        //    Item item = db.Item.Find(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(item);
        //}

        //// PUT: api/Items/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutItem(int id, Item item)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != item.ItemID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(item).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Items
        //[ResponseType(typeof(Item))]
        //public IHttpActionResult PostItem(Item item)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Item.Add(item);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = item.ItemID }, item);
        //}

        //// DELETE: api/Items/5
        //[ResponseType(typeof(Item))]
        //public IHttpActionResult DeleteItem(int id)
        //{
        //    Item item = db.Item.Find(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Item.Remove(item);
        //    db.SaveChanges();

        //    return Ok(item);
        //}
        //    private bool ItemExists(int id)
        //    {
        //        return db.Item.Count(e => e.ItemID == id) > 0;
        //    }
        #endregion 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}