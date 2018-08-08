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
    public partial class TB_DATASERVERController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/TB_DATASERVER
            [EnableQuery]
            public IQueryable<TB_DATASERVER> GetTB_DATASERVER()
            {
                return db.TB_DATASERVER;
            }
    
            // GET: odata/TB_DATASERVER(5)
            [EnableQuery]
            public SingleResult<TB_DATASERVER> GetTB_DATASERVER([FromODataUri] string key)
            {
                return SingleResult.Create(db.TB_DATASERVER.Where(w => w.ID == key));
            }
    
            // PUT: odata/TB_DATASERVER(5)
            public IHttpActionResult Put([FromODataUri] string key, Delta<TB_DATASERVER> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                TB_DATASERVER TB_DATASERVER = db.TB_DATASERVER.Find(key);
                if (TB_DATASERVER == null)
                {
                    return NotFound();
                }
    
                patch.Put(TB_DATASERVER);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TB_DATASERVERExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(TB_DATASERVER);
            }
    
            // POST: odata/TB_DATASERVER
            public IHttpActionResult Post(TB_DATASERVER TB_DATASERVER)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.TB_DATASERVER.Add(TB_DATASERVER);
                db.SaveChanges();
    
                return Created(TB_DATASERVER);
            }
    
            // PATCH: odata/TB_DATASERVER(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] string key, Delta<TB_DATASERVER> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                TB_DATASERVER TB_DATASERVER = db.TB_DATASERVER.Find(key);
                if (TB_DATASERVER == null)
                {
                    return NotFound();
                }
    
                patch.Patch(TB_DATASERVER);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TB_DATASERVERExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(TB_DATASERVER);
            }
    
            // DELETE: odata/TB_DATASERVER(5)
            public IHttpActionResult Delete([FromODataUri] string key)
            {
                TB_DATASERVER TB_DATASERVER = db.TB_DATASERVER.Find(key);
                if (TB_DATASERVER == null)
                {
                    return NotFound();
                }
    
                db.TB_DATASERVER.Remove(TB_DATASERVER);
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
    
            private bool TB_DATASERVERExists(string key)
            {
                return db.TB_DATASERVER.Count(e => e.ID == key) > 0;
            }
      
    }
}
