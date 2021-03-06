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
    public partial class T_DRAINPIPE_TESTController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_DRAINPIPE_TEST
            [EnableQuery]
            public IQueryable<T_DRAINPIPE_TEST> GetT_DRAINPIPE_TEST()
            {
                return db.T_DRAINPIPE_TEST;
            }
    
            // GET: odata/T_DRAINPIPE_TEST(5)
            [EnableQuery]
            public SingleResult<T_DRAINPIPE_TEST> GetT_DRAINPIPE_TEST([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_DRAINPIPE_TEST.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_DRAINPIPE_TEST(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_DRAINPIPE_TEST> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_DRAINPIPE_TEST T_DRAINPIPE_TEST = db.T_DRAINPIPE_TEST.Find(key);
                if (T_DRAINPIPE_TEST == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_DRAINPIPE_TEST);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_DRAINPIPE_TESTExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_DRAINPIPE_TEST);
            }
    
            // POST: odata/T_DRAINPIPE_TEST
            public IHttpActionResult Post(T_DRAINPIPE_TEST T_DRAINPIPE_TEST)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_DRAINPIPE_TEST.Add(T_DRAINPIPE_TEST);
                db.SaveChanges();
    
                return Created(T_DRAINPIPE_TEST);
            }
    
            // PATCH: odata/T_DRAINPIPE_TEST(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_DRAINPIPE_TEST> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_DRAINPIPE_TEST T_DRAINPIPE_TEST = db.T_DRAINPIPE_TEST.Find(key);
                if (T_DRAINPIPE_TEST == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_DRAINPIPE_TEST);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_DRAINPIPE_TESTExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_DRAINPIPE_TEST);
            }
    
            // DELETE: odata/T_DRAINPIPE_TEST(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_DRAINPIPE_TEST T_DRAINPIPE_TEST = db.T_DRAINPIPE_TEST.Find(key);
                if (T_DRAINPIPE_TEST == null)
                {
                    return NotFound();
                }
    
                db.T_DRAINPIPE_TEST.Remove(T_DRAINPIPE_TEST);
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
    
            private bool T_DRAINPIPE_TESTExists(decimal key)
            {
                return db.T_DRAINPIPE_TEST.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
