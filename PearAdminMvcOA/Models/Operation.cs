//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PearAdminMvcOA.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Operation
    {
        public int Logid { get; set; }
        public string OperationContent { get; set; }
        public int Userid { get; set; }
        public string host { get; set; }
        public System.DateTime Operationtime { get; set; }
        [JsonIgnore]
        public virtual UserInfo UserInfo { get; set; }
    }
}
