//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIAnsokan.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class Vardnadshavare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vardnadshavare()
        {
            this.Ansokan = new HashSet<Ansokan>();
        }
    
        public string Vardnadshavarepersonnummer { get; set; }
        public string Fornamn { get; set; }
        public string Efternamn { get; set; }
        public string Anvandarnamn { get; set; }
        public string Losenord { get; set; }
        public string Andranamn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<Ansokan> Ansokan { get; set; }
    }
}