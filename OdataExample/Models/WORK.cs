//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OdataExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WORK
    {
        public string EID { get; set; }
        public string DID { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<int> SALARY { get; set; }
    
        public virtual EMP EMP { get; set; }
    }
}
