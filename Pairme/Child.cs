//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pairme
{
    using System;
    using System.Collections.Generic;
    
    public partial class Child
    {
        public Child()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public int ID { get; set; }
        public string ChildrenName { get; set; }
    
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
