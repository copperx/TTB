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
    
    public partial class tag
    {
        public tag()
        {
            this.tagsToProjects = new HashSet<tagsToProject>();
        }
    
        public int tagID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<tagsToProject> tagsToProjects { get; set; }
    }
}