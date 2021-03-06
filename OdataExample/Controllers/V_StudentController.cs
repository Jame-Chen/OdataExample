//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OdataExample.Controllers
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
    using OdataExample.Models;
    public partial class V_StudentController:ODataController
    {
            private odataEntities db = new odataEntities();
    
            // GET: odata/V_Student
            [EnableQuery]
            public IQueryable<V_Student> GetV_Student()
            {
                return db.V_Student;
            }
    
            // GET: odata/V_Student(5)
            [EnableQuery]
            public SingleResult<V_Student> GetV_Student([FromODataUri] int key)
            {
                return SingleResult.Create(db.V_Student.Where(w => w.Id == key));
            }
    
            // PUT: odata/V_Student(5)
            public IHttpActionResult Put([FromODataUri] int key, Delta<V_Student> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_Student V_Student = db.V_Student.Find(key);
                if (V_Student == null)
                {
                    return NotFound();
                }
    
                patch.Put(V_Student);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_StudentExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_Student);
            }
    
            // POST: odata/V_Student
            public IHttpActionResult Post(V_Student V_Student)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                db.V_Student.Add(V_Student);
                db.SaveChanges();
    
                return Created(V_Student);
            }
    
            // PATCH: odata/V_Student(5)
            [AcceptVerbs("PATCH", "MERGE")]
            public IHttpActionResult Patch([FromODataUri] int key, Delta<V_Student> patch)
            {
                Validate(patch.GetEntity());
    
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                V_Student V_Student = db.V_Student.Find(key);
                if (V_Student == null)
                {
                    return NotFound();
                }
    
                patch.Patch(V_Student);
    
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!V_StudentExists(key))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
    
                return Updated(V_Student);
            }
    
            // DELETE: odata/V_Student(5)
            public IHttpActionResult Delete([FromODataUri] int key)
            {
                V_Student V_Student = db.V_Student.Find(key);
                if (V_Student == null)
                {
                    return NotFound();
                }
    
                db.V_Student.Remove(V_Student);
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
    
            private bool V_StudentExists(int key)
            {
                return db.V_Student.Count(e => e.Id == key) > 0;
            }
      
    }
}
