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
    
    public partial class product
    {
        public product()
        {
            this.orders = new HashSet<order>();
        }
    
        public int productID { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<int> accessLevel { get; set; }
    
        public virtual ICollection<order> orders { get; set; }
    }
}
