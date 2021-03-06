//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OdataExampleForOracle.Controllers
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.ModelBinding;
    using System.Web.Http.OData;
    using System.Web.Http.OData.Routing;
    using OdataExampleForOracle.Models;
    public partial class T_HDLCZOLDController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_HDLCZOLD
            [EnableQuery]
            public IQueryable<T_HDLCZOLD> GetT_HDLCZOLD()
            {
                return db.T_HDLCZOLD;
            }
    
            // GET: odata/T_HDLCZOLD(5)
            [EnableQuery]
            public SingleResult<T_HDLCZOLD> GetT_HDLCZOLD([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_HDLCZOLD.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_HDLCZOLD(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_HDLCZOLD> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_HDLCZOLD T_HDLCZOLD = db.T_HDLCZOLD.Find(key);
                if (T_HDLCZOLD == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_HDLCZOLD);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_HDLCZOLDExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_HDLCZOLD);
            }
    
            // POST: odata/T_HDLCZOLD
            public IHttpActionResult Post(T_HDLCZOLD T_HDLCZOLD)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_HDLCZOLD.Add(T_HDLCZOLD);
                db.SaveChanges();
    
                return Created(T_HDLCZOLD);
            }
    
            // PATCH: odata/T_HDLCZOLD(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_HDLCZOLD> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_HDLCZOLD T_HDLCZOLD = db.T_HDLCZOLD.Find(key);
                if (T_HDLCZOLD == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_HDLCZOLD);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_HDLCZOLDExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_HDLCZOLD);
            }
    
            // DELETE: odata/T_HDLCZOLD(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_HDLCZOLD T_HDLCZOLD = db.T_HDLCZOLD.Find(key);
                if (T_HDLCZOLD == null)
                {
                    return NotFound();
                }
    
                db.T_HDLCZOLD.Remove(T_HDLCZOLD);
                db.SaveChanges();
    
                return StatusCode(HttpStatusCode.NoContent);
            }
    
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                base.Dispose(disposing);
            }
    
            private bool T_HDLCZOLDExists(decimal key)
            {
                return db.T_HDLCZOLD.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
