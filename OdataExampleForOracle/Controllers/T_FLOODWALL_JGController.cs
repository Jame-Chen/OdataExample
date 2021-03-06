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
    public partial class T_FLOODWALL_JGController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_FLOODWALL_JG
            [EnableQuery]
            public IQueryable<T_FLOODWALL_JG> GetT_FLOODWALL_JG()
            {
                return db.T_FLOODWALL_JG;
            }
    
            // GET: odata/T_FLOODWALL_JG(5)
            [EnableQuery]
            public SingleResult<T_FLOODWALL_JG> GetT_FLOODWALL_JG([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_FLOODWALL_JG.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_FLOODWALL_JG(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_FLOODWALL_JG> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FLOODWALL_JG T_FLOODWALL_JG = db.T_FLOODWALL_JG.Find(key);
                if (T_FLOODWALL_JG == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_FLOODWALL_JG);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FLOODWALL_JGExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FLOODWALL_JG);
            }
    
            // POST: odata/T_FLOODWALL_JG
            public IHttpActionResult Post(T_FLOODWALL_JG T_FLOODWALL_JG)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_FLOODWALL_JG.Add(T_FLOODWALL_JG);
                db.SaveChanges();
    
                return Created(T_FLOODWALL_JG);
            }
    
            // PATCH: odata/T_FLOODWALL_JG(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_FLOODWALL_JG> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FLOODWALL_JG T_FLOODWALL_JG = db.T_FLOODWALL_JG.Find(key);
                if (T_FLOODWALL_JG == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_FLOODWALL_JG);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FLOODWALL_JGExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FLOODWALL_JG);
            }
    
            // DELETE: odata/T_FLOODWALL_JG(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_FLOODWALL_JG T_FLOODWALL_JG = db.T_FLOODWALL_JG.Find(key);
                if (T_FLOODWALL_JG == null)
                {
                    return NotFound();
                }
    
                db.T_FLOODWALL_JG.Remove(T_FLOODWALL_JG);
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
    
            private bool T_FLOODWALL_JGExists(decimal key)
            {
                return db.T_FLOODWALL_JG.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
