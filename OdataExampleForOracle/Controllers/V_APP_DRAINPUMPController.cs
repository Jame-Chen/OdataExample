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
    public partial class V_APP_DRAINPUMPController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/V_APP_DRAINPUMP
            [EnableQuery]
            public IQueryable<V_APP_DRAINPUMP> GetV_APP_DRAINPUMP()
            {
                return db.V_APP_DRAINPUMP;
            }
    
            // GET: odata/V_APP_DRAINPUMP(5)
            [EnableQuery]
            public SingleResult<V_APP_DRAINPUMP> GetV_APP_DRAINPUMP([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.V_APP_DRAINPUMP.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/V_APP_DRAINPUMP(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<V_APP_DRAINPUMP> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_APP_DRAINPUMP V_APP_DRAINPUMP = db.V_APP_DRAINPUMP.Find(key);
                if (V_APP_DRAINPUMP == null)
                {
                    return NotFound();
                }
    
                patch.Put(V_APP_DRAINPUMP);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_APP_DRAINPUMPExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_APP_DRAINPUMP);
            }
    
            // POST: odata/V_APP_DRAINPUMP
            public IHttpActionResult Post(V_APP_DRAINPUMP V_APP_DRAINPUMP)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.V_APP_DRAINPUMP.Add(V_APP_DRAINPUMP);
                db.SaveChanges();
    
                return Created(V_APP_DRAINPUMP);
            }
    
            // PATCH: odata/V_APP_DRAINPUMP(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<V_APP_DRAINPUMP> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_APP_DRAINPUMP V_APP_DRAINPUMP = db.V_APP_DRAINPUMP.Find(key);
                if (V_APP_DRAINPUMP == null)
                {
                    return NotFound();
                }
    
                patch.Patch(V_APP_DRAINPUMP);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_APP_DRAINPUMPExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_APP_DRAINPUMP);
            }
    
            // DELETE: odata/V_APP_DRAINPUMP(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                V_APP_DRAINPUMP V_APP_DRAINPUMP = db.V_APP_DRAINPUMP.Find(key);
                if (V_APP_DRAINPUMP == null)
                {
                    return NotFound();
                }
    
                db.V_APP_DRAINPUMP.Remove(V_APP_DRAINPUMP);
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
    
            private bool V_APP_DRAINPUMPExists(decimal key)
            {
                return db.V_APP_DRAINPUMP.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
