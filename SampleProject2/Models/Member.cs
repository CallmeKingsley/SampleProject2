//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleProject2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberRelation { get; set; }
        public string MemberAddress { get; set; }
        public int UserID { get; set; }
    
        public virtual Member Member1 { get; set; }
        public virtual Member Member2 { get; set; }
    }
}
