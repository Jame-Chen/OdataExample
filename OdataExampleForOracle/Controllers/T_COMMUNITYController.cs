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
    public partial class T_COMMUNITYController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_COMMUNITY
            [EnableQuery]
            public IQueryable<T_COMMUNITY> GetT_COMMUNITY()
            {
                return db.T_COMMUNITY;
            }
    
            // GET: odata/T_COMMUNITY(5)
            [EnableQuery]
            public SingleResult<T_COMMUNITY> GetT_COMMUNITY([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_COMMUNITY.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_COMMUNITY(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_COMMUNITY> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_COMMUNITY T_COMMUNITY = db.T_COMMUNITY.Find(key);
                if (T_COMMUNITY == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_COMMUNITY);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_COMMUNITYExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_COMMUNITY);
            }
    
            // POST: odata/T_COMMUNITY
            public IHttpActionResult Post(T_COMMUNITY T_COMMUNITY)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_COMMUNITY.Add(T_COMMUNITY);
                db.SaveChanges();
    
                return Created(T_COMMUNITY);
            }
    
            // PATCH: odata/T_COMMUNITY(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_COMMUNITY> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_COMMUNITY T_COMMUNITY = db.T_COMMUNITY.Find(key);
                if (T_COMMUNITY == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_COMMUNITY);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_COMMUNITYExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_COMMUNITY);
            }
    
            // DELETE: odata/T_COMMUNITY(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_COMMUNITY T_COMMUNITY = db.T_COMMUNITY.Find(key);
                if (T_COMMUNITY == null)
                {
                    return NotFound();
                }
    
                db.T_COMMUNITY.Remove(T_COMMUNITY);
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
    
            private bool T_COMMUNITYExists(decimal key)
            {
                return db.T_COMMUNITY.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
