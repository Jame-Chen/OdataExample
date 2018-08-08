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
    public partial class T_DRAINUSERController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_DRAINUSER
            [EnableQuery]
            public IQueryable<T_DRAINUSER> GetT_DRAINUSER()
            {
                return db.T_DRAINUSER;
            }
    
            // GET: odata/T_DRAINUSER(5)
            [EnableQuery]
            public SingleResult<T_DRAINUSER> GetT_DRAINUSER([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_DRAINUSER.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_DRAINUSER(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_DRAINUSER> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_DRAINUSER T_DRAINUSER = db.T_DRAINUSER.Find(key);
                if (T_DRAINUSER == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_DRAINUSER);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_DRAINUSERExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_DRAINUSER);
            }
    
            // POST: odata/T_DRAINUSER
            public IHttpActionResult Post(T_DRAINUSER T_DRAINUSER)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_DRAINUSER.Add(T_DRAINUSER);
                db.SaveChanges();
    
                return Created(T_DRAINUSER);
            }
    
            // PATCH: odata/T_DRAINUSER(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_DRAINUSER> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_DRAINUSER T_DRAINUSER = db.T_DRAINUSER.Find(key);
                if (T_DRAINUSER == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_DRAINUSER);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_DRAINUSERExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_DRAINUSER);
            }
    
            // DELETE: odata/T_DRAINUSER(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_DRAINUSER T_DRAINUSER = db.T_DRAINUSER.Find(key);
                if (T_DRAINUSER == null)
                {
                    return NotFound();
                }
    
                db.T_DRAINUSER.Remove(T_DRAINUSER);
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
    
            private bool T_DRAINUSERExists(decimal key)
            {
                return db.T_DRAINUSER.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
