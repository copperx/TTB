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
    
    public partial class tagsToProject
    {
        public int tagID { get; set; }
        public int projectID { get; set; }
        public Nullable<System.DateTime> dateAdded { get; set; }
    
        public virtual tag tag { get; set; }
        public virtual project project { get; set; }
    }
}