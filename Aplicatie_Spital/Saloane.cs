//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LAGE_APP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Saloane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Saloane()
        {
            this.Asistentis = new HashSet<Asistenti>();
            this.Infirmieris = new HashSet<Infirmieri>();
            this.Pacientis = new HashSet<Pacienti>();
        }
    
        public int SalonId { get; set; }
        public Nullable<int> NrSalon { get; set; }
        public string Specializare { get; set; }
        public Nullable<int> Capacitate { get; set; }
        public Nullable<int> Ocupat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asistenti> Asistentis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infirmieri> Infirmieris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pacienti> Pacientis { get; set; }
    }
}