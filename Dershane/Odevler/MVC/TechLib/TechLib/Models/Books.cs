//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechLib.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Books()
        {
            this.Loans = new HashSet<Loans>();
            this.Reservations = new HashSet<Reservations>();
            this.Authors = new HashSet<Authors>();
        }
    
        public int ID { get; set; }
        public string BookName { get; set; }
        public int GenreID { get; set; }
        public int LanguageID { get; set; }
        public int PublishingHouseID { get; set; }
        public short BookNumber { get; set; }
        public string Barcode { get; set; }
        public byte[] BookImage { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loans> Loans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservations> Reservations { get; set; }
        public virtual Genres Genres { get; set; }
        public virtual Languages Languages { get; set; }
        public virtual PublishingHouses PublishingHouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authors> Authors { get; set; }
    }
}