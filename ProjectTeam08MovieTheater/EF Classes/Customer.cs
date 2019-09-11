namespace ProjectTeam08MovieTheater.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int CustId { get; set; }

        [Required]
        [StringLength(30)]
        public string CustFirstname { get; set; }

        [Required]
        [StringLength(30)]
        public string CustLastname { get; set; }

        public int CustAge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
