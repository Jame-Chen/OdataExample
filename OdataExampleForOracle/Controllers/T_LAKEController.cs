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
    public partial class T_LAKEController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_LAKE
            [EnableQuery]
            public IQueryable<T_LAKE> GetT_LAKE()
            {
                return db.T_LAKE;
            }
    
            // GET: odata/T_LAKE(5)
            [EnableQuery]
            public SingleResult<T_LAKE> GetT_LAKE([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_LAKE.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_LAKE(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_LAKE> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_LAKE T_LAKE = db.T_LAKE.Find(key);
                if (T_LAKE == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_LAKE);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_LAKEExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_LAKE);
            }
    
            // POST: odata/T_LAKE
            public IHttpActionResult Post(T_LAKE T_LAKE)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_LAKE.Add(T_LAKE);
                db.SaveChanges();
    
                return Created(T_LAKE);
            }
    
            // PATCH: odata/T_LAKE(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_LAKE> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_LAKE T_LAKE = db.T_LAKE.Find(key);
                if (T_LAKE == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_LAKE);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_LAKEExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_LAKE);
            }
    
            // DELETE: odata/T_LAKE(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_LAKE T_LAKE = db.T_LAKE.Find(key);
                if (T_LAKE == null)
                {
                    return NotFound();
                }
    
                db.T_LAKE.Remove(T_LAKE);
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
    
            private bool T_LAKEExists(decimal key)
            {
                return db.T_LAKE.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
