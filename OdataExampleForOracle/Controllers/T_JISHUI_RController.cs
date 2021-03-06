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
    public partial class T_JISHUI_RController:ODataController
    {
            private SJZXEntities db = new SJZXEntities();
    
            // GET: odata/T_JISHUI_R
            [EnableQuery]
            public IQueryable<T_JISHUI_R> GetT_JISHUI_R()
            {
                return db.T_JISHUI_R;
            }
    
            // GET: odata/T_JISHUI_R(5)
            [EnableQuery]
            public SingleResult<T_JISHUI_R> GetT_JISHUI_R([FromODataUri] decimal key)
            {
                return SingleResult.Create(db.T_JISHUI_R.Where(w => w.N_ID == key));
            }
    
            // PUT: odata/T_JISHUI_R(5)
            public IHttpActionResult Put([FromODataUri] decimal key, Delta<T_JISHUI_R> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_JISHUI_R T_JISHUI_R = db.T_JISHUI_R.Find(key);
                if (T_JISHUI_R == null)
                {
                    return NotFound();
                }
    
                patch.Put(T_JISHUI_R);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_JISHUI_RExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_JISHUI_R);
            }
    
            // POST: odata/T_JISHUI_R
            public IHttpActionResult Post(T_JISHUI_R T_JISHUI_R)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.T_JISHUI_R.Add(T_JISHUI_R);
                db.SaveChanges();
    
                return Created(T_JISHUI_R);
            }
    
            // PATCH: odata/T_JISHUI_R(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] decimal key, Delta<T_JISHUI_R> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                T_JISHUI_R T_JISHUI_R = db.T_JISHUI_R.Find(key);
                if (T_JISHUI_R == null)
                {
                    return NotFound();
                }
    
                patch.Patch(T_JISHUI_R);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!T_JISHUI_RExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(T_JISHUI_R);
            }
    
            // DELETE: odata/T_JISHUI_R(5)
            public IHttpActionResult Delete([FromODataUri] decimal key)
            {
                T_JISHUI_R T_JISHUI_R = db.T_JISHUI_R.Find(key);
                if (T_JISHUI_R == null)
                {
                    return NotFound();
                }
    
                db.T_JISHUI_R.Remove(T_JISHUI_R);
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
    
            private bool T_JISHUI_RExists(decimal key)
            {
                return db.T_JISHUI_R.Count(e => e.N_ID == key) > 0;
            }
      
    }
}
