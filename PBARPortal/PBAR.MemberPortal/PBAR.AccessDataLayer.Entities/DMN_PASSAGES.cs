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
    
    public partial class DMN_PASSAGES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DMN_PASSAGES()
        {
            this.DMN_CREWLIST = new HashSet<DMN_CREWLIST>();
            this.DMN_PASSAGEACCESS = new HashSet<DMN_PASSAGEACCESS>();
        }
    
        public int PASSAGEID { get; set; }
        public int VESSELID { get; set; }
        public string VOYAGENUMBER { get; set; }
        public Nullable<int> JOURNEYTYPEID { get; set; }
        public string JOURNEYDATE { get; set; }
        public string PORTNAME { get; set; }
        public string LASTPORTOFCALL { get; set; }
        public string CREATEDBY { get; set; }
        public Nullable<System.DateTime> CREATEDOON { get; set; }
    
        public virtual DMN_CORPORATEVESSELS DMN_CORPORATEVESSELS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMN_CREWLIST> DMN_CREWLIST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DMN_PASSAGEACCESS> DMN_PASSAGEACCESS { get; set; }
    }
}
