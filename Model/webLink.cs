//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTB_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class webLink
    {
        public webLink()
        {
            this.projects = new HashSet<project>();
        }
    
        public int weblinkID { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string listPriority { get; set; }
        public Nullable<int> typeID { get; set; }
    
        public virtual weblinksType weblinksType { get; set; }
        public virtual ICollection<project> projects { get; set; }
    }
}
