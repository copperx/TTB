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
    
    public partial class collection
    {
        public collection()
        {
            this.items = new HashSet<item>();
        }
    
        public int collectionID { get; set; }
        public string collectionName { get; set; }
    
        public virtual ICollection<item> items { get; set; }
    }
}
