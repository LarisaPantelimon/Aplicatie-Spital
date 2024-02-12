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
    
    public partial class Pacienti
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacienti()
        {
            this.AnalizeDoctoris = new HashSet<AnalizeDoctori>();
            this.Facturi_Pacienti = new HashSet<Facturi_Pacienti>();
            this.Programari_Pacienti = new HashSet<Programari_Pacienti>();
        }
    
        public int PacientId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NrTel { get; set; }
        public string Email { get; set; }
        public Nullable<int> Gen { get; set; }
        public string CNP { get; set; }
        public Nullable<System.DateTime> DataNastere { get; set; }
        public Nullable<int> Asigurare { get; set; }
        public string Ocupatie { get; set; }
        public string Boala { get; set; }
        public string Parola { get; set; }
        public Nullable<int> SalonId { get; set; }
        public Nullable<int> Internat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnalizeDoctori> AnalizeDoctoris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturi_Pacienti> Facturi_Pacienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programari_Pacienti> Programari_Pacienti { get; set; }
        public virtual Saloane Saloane { get; set; }
    }
}
