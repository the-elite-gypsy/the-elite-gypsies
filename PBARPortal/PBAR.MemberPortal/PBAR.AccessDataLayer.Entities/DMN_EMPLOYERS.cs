//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBAR.AccessDataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DMN_EMPLOYERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMN_EMPLOYERS()
        {
            this.DMN_FISHINGLIST = new HashSet<DMN_FISHINGLIST>();
            this.DMN_JOBPOSTING = new HashSet<DMN_JOBPOSTING>();
        }
    
        public int EMPLOYERID { get; set; }
        public string REFERENCE { get; set; }
        public Nullable<int> SUBSCRIPTIONID { get; set; }
        public string STATUS { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<System.DateTime> CREATEDON { get; set; }
        public string CREATEDBY { get; set; }
    
        public virtual DMN_EMPLOYERPROFILE DMN_EMPLOYERPROFILE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMN_FISHINGLIST> DMN_FISHINGLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMN_JOBPOSTING> DMN_JOBPOSTING { get; set; }
    }
}
