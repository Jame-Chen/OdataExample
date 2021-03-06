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
    public partial class V_PM_PROJECTController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/V_PM_PROJECT
            [EnableQuery]
            public IQueryable<V_PM_PROJECT> GetV_PM_PROJECT()
            {
                return db.V_PM_PROJECT;
            }
    
            // GET: odata/V_PM_PROJECT(5)
            [EnableQuery]
            public SingleResult<V_PM_PROJECT> GetV_PM_PROJECT([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.V_PM_PROJECT.Where(w => w.PROJECT_ID == key));
            }
    
            // PUT: odata/V_PM_PROJECT(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<V_PM_PROJECT> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_PM_PROJECT V_PM_PROJECT = db.V_PM_PROJECT.Find(key);
                if (V_PM_PROJECT == null)
                {
                    return NotFound();
                }
    
                patch.Put(V_PM_PROJECT);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_PM_PROJECTExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_PM_PROJECT);
            }
    
            // POST: odata/V_PM_PROJECT
            public IHttpActionResult Post(V_PM_PROJECT V_PM_PROJECT)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.V_PM_PROJECT.Add(V_PM_PROJECT);
                db.SaveChanges();
    
                return Created(V_PM_PROJECT);
            }
    
            // PATCH: odata/V_PM_PROJECT(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<V_PM_PROJECT> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_PM_PROJECT V_PM_PROJECT = db.V_PM_PROJECT.Find(key);
                if (V_PM_PROJECT == null)
                {
                    return NotFound();
                }
    
                patch.Patch(V_PM_PROJECT);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_PM_PROJECTExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_PM_PROJECT);
            }
    
            // DELETE: odata/V_PM_PROJECT(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                V_PM_PROJECT V_PM_PROJECT = db.V_PM_PROJECT.Find(key);
                if (V_PM_PROJECT == null)
                {
                    return NotFound();
                }
    
                db.V_PM_PROJECT.Remove(V_PM_PROJECT);
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
    
            private bool V_PM_PROJECTExists(decimal key)
            {
                return db.V_PM_PROJECT.Count(e => e.PROJECT_ID == key) > 0;
            }
      
    }
}
