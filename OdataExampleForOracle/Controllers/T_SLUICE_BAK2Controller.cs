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
    public partial class T_SLUICE_BAK2Controller:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_SLUICE_BAK2
            [EnableQuery]
            public IQueryable<T_SLUICE_BAK2> GetT_SLUICE_BAK2()
            {
                return db.T_SLUICE_BAK2;
            }
    
            // GET: odata/T_SLUICE_BAK2(5)
            [EnableQuery]
            public SingleResult<T_SLUICE_BAK2> GetT_SLUICE_BAK2([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_SLUICE_BAK2.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_SLUICE_BAK2(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_SLUICE_BAK2> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_SLUICE_BAK2 T_SLUICE_BAK2 = db.T_SLUICE_BAK2.Find(key);
                if (T_SLUICE_BAK2 == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_SLUICE_BAK2);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_SLUICE_BAK2Exists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_SLUICE_BAK2);
            }
    
            // POST: odata/T_SLUICE_BAK2
            public IHttpActionResult Post(T_SLUICE_BAK2 T_SLUICE_BAK2)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_SLUICE_BAK2.Add(T_SLUICE_BAK2);
                db.SaveChanges();
    
                return Created(T_SLUICE_BAK2);
            }
    
            // PATCH: odata/T_SLUICE_BAK2(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_SLUICE_BAK2> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_SLUICE_BAK2 T_SLUICE_BAK2 = db.T_SLUICE_BAK2.Find(key);
                if (T_SLUICE_BAK2 == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_SLUICE_BAK2);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_SLUICE_BAK2Exists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_SLUICE_BAK2);
            }
    
            // DELETE: odata/T_SLUICE_BAK2(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_SLUICE_BAK2 T_SLUICE_BAK2 = db.T_SLUICE_BAK2.Find(key);
                if (T_SLUICE_BAK2 == null)
                {
                    return NotFound();
                }
    
                db.T_SLUICE_BAK2.Remove(T_SLUICE_BAK2);
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
    
            private bool T_SLUICE_BAK2Exists(decimal key)
            {
                return db.T_SLUICE_BAK2.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
