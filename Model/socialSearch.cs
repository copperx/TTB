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
    
    public partial class socialSearch
    {
        public socialSearch()
        {
            this.people = new HashSet<person>();
            this.projects = new HashSet<project>();
        }
    
        public int socialSearchID { get; set; }
        public Nullable<int> dataSetID { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> pageID { get; set; }
        public string keywords { get; set; }
    
        public virtual ICollection<person> people { get; set; }
        public virtual ICollection<project> projects { get; set; }
    }
}
