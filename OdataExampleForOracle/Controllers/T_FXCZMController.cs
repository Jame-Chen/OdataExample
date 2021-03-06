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
    public partial class T_FXCZMController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_FXCZM
            [EnableQuery]
            public IQueryable<T_FXCZM> GetT_FXCZM()
            {
                return db.T_FXCZM;
            }
    
            // GET: odata/T_FXCZM(5)
            [EnableQuery]
            public SingleResult<T_FXCZM> GetT_FXCZM([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_FXCZM.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_FXCZM(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_FXCZM> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FXCZM T_FXCZM = db.T_FXCZM.Find(key);
                if (T_FXCZM == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_FXCZM);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FXCZMExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FXCZM);
            }
    
            // POST: odata/T_FXCZM
            public IHttpActionResult Post(T_FXCZM T_FXCZM)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_FXCZM.Add(T_FXCZM);
                db.SaveChanges();
    
                return Created(T_FXCZM);
            }
    
            // PATCH: odata/T_FXCZM(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_FXCZM> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FXCZM T_FXCZM = db.T_FXCZM.Find(key);
                if (T_FXCZM == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_FXCZM);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FXCZMExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FXCZM);
            }
    
            // DELETE: odata/T_FXCZM(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_FXCZM T_FXCZM = db.T_FXCZM.Find(key);
                if (T_FXCZM == null)
                {
                    return NotFound();
                }
    
                db.T_FXCZM.Remove(T_FXCZM);
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
    
            private bool T_FXCZMExists(decimal key)
            {
                return db.T_FXCZM.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
