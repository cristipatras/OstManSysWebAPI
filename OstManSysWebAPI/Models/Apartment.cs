namespace OstManSysWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apartment")]
    public partial class Apartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartment()
        {
            Residents = new HashSet<Resident>();
        }

        public int ApartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public int Size { get; set; }

        public int NumberOfRooms { get; set; }

        public int MonthlyRent { get; set; }

        [Required]
        [StringLength(250)]
        public string Condition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resident> Residents { get; set; }
    }
}
