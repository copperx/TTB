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
    
    public partial class company
    {
        public company()
        {
            this.companyTypes = new HashSet<companyType>();
        }
    
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string companyWebsite { get; set; }
    
        public virtual peopleToCompany peopleToCompany { get; set; }
        public virtual ICollection<companyType> companyTypes { get; set; }
    }
}
