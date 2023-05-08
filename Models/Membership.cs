//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MandhegParkingSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Membership
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membership()
        {
            this.HourlyRates = new HashSet<HourlyRate>();
            this.Members = new HashSet<Member>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> last_updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourlyRate> HourlyRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Member> Members { get; set; }
    }
}