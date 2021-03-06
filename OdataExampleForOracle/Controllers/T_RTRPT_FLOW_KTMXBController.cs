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
    public partial class T_RTRPT_FLOW_KTMXBController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_RTRPT_FLOW_KTMXB
            [EnableQuery]
            public IQueryable<T_RTRPT_FLOW_KTMXB> GetT_RTRPT_FLOW_KTMXB()
            {
                return db.T_RTRPT_FLOW_KTMXB;
            }
    
            // GET: odata/T_RTRPT_FLOW_KTMXB(5)
            [EnableQuery]
            public SingleResult<T_RTRPT_FLOW_KTMXB> GetT_RTRPT_FLOW_KTMXB([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_RTRPT_FLOW_KTMXB.Where(w => w.N_ID == key));
            }
    
            // PUT: odata/T_RTRPT_FLOW_KTMXB(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_RTRPT_FLOW_KTMXB> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_RTRPT_FLOW_KTMXB T_RTRPT_FLOW_KTMXB = db.T_RTRPT_FLOW_KTMXB.Find(key);
                if (T_RTRPT_FLOW_KTMXB == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_RTRPT_FLOW_KTMXB);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_RTRPT_FLOW_KTMXBExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_RTRPT_FLOW_KTMXB);
            }
    
            // POST: odata/T_RTRPT_FLOW_KTMXB
            public IHttpActionResult Post(T_RTRPT_FLOW_KTMXB T_RTRPT_FLOW_KTMXB)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_RTRPT_FLOW_KTMXB.Add(T_RTRPT_FLOW_KTMXB);
                db.SaveChanges();
    
                return Created(T_RTRPT_FLOW_KTMXB);
            }
    
            // PATCH: odata/T_RTRPT_FLOW_KTMXB(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_RTRPT_FLOW_KTMXB> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_RTRPT_FLOW_KTMXB T_RTRPT_FLOW_KTMXB = db.T_RTRPT_FLOW_KTMXB.Find(key);
                if (T_RTRPT_FLOW_KTMXB == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_RTRPT_FLOW_KTMXB);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_RTRPT_FLOW_KTMXBExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_RTRPT_FLOW_KTMXB);
            }
    
            // DELETE: odata/T_RTRPT_FLOW_KTMXB(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_RTRPT_FLOW_KTMXB T_RTRPT_FLOW_KTMXB = db.T_RTRPT_FLOW_KTMXB.Find(key);
                if (T_RTRPT_FLOW_KTMXB == null)
                {
                    return NotFound();
                }
    
                db.T_RTRPT_FLOW_KTMXB.Remove(T_RTRPT_FLOW_KTMXB);
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
    
            private bool T_RTRPT_FLOW_KTMXBExists(decimal key)
            {
                return db.T_RTRPT_FLOW_KTMXB.Count(e => e.N_ID == key) > 0;
            }
      
    }
}
