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
    
    public partial class LoginLog
    {
        public int LoginId { get; set; }
        public int UserId { get; set; }
        public System.DateTime LoginTime { get; set; }
        public int IfSuccess { get; set; }
        public string LoginUserIp { get; set; }
        public string LoginDesc { get; set; }
        public string Browser { get; set; }
        [JsonIgnore]
        public virtual UserInfo UserInfo { get; set; }
    }
}
