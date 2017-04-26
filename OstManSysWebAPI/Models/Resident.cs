namespace OstManSysWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resident")]
    public partial class Resident
    {
        public int ResidentID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        [Required]
        [StringLength(60)]
        public string EmailAddress { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public bool IsBoardMember { get; set; }

        public int ApartmentID { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }

        [Column(TypeName = "date")]
        public DateTime MoveInDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime MoveOutDate { get; set; }

        public bool IsOwner { get; set; }

        public virtual Apartment Apartment { get; set; }
    }
}
