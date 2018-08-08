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
    public partial class T_FLOODWALL_DWController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_FLOODWALL_DW
            [EnableQuery]
            public IQueryable<T_FLOODWALL_DW> GetT_FLOODWALL_DW()
            {
                return db.T_FLOODWALL_DW;
            }
    
            // GET: odata/T_FLOODWALL_DW(5)
            [EnableQuery]
            public SingleResult<T_FLOODWALL_DW> GetT_FLOODWALL_DW([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_FLOODWALL_DW.Where(w => w.OBJECTID == key));
            }
    
            // PUT: odata/T_FLOODWALL_DW(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_FLOODWALL_DW> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FLOODWALL_DW T_FLOODWALL_DW = db.T_FLOODWALL_DW.Find(key);
                if (T_FLOODWALL_DW == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_FLOODWALL_DW);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FLOODWALL_DWExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FLOODWALL_DW);
            }
    
            // POST: odata/T_FLOODWALL_DW
            public IHttpActionResult Post(T_FLOODWALL_DW T_FLOODWALL_DW)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_FLOODWALL_DW.Add(T_FLOODWALL_DW);
                db.SaveChanges();
    
                return Created(T_FLOODWALL_DW);
            }
    
            // PATCH: odata/T_FLOODWALL_DW(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_FLOODWALL_DW> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_FLOODWALL_DW T_FLOODWALL_DW = db.T_FLOODWALL_DW.Find(key);
                if (T_FLOODWALL_DW == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_FLOODWALL_DW);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_FLOODWALL_DWExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_FLOODWALL_DW);
            }
    
            // DELETE: odata/T_FLOODWALL_DW(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_FLOODWALL_DW T_FLOODWALL_DW = db.T_FLOODWALL_DW.Find(key);
                if (T_FLOODWALL_DW == null)
                {
                    return NotFound();
                }
    
                db.T_FLOODWALL_DW.Remove(T_FLOODWALL_DW);
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
    
            private bool T_FLOODWALL_DWExists(decimal key)
            {
                return db.T_FLOODWALL_DW.Count(e => e.OBJECTID == key) > 0;
            }
      
    }
}
