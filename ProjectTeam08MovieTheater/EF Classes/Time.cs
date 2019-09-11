namespace ProjectTeam08MovieTheater.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Time")]
    public partial class Time
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Time()
        {
            Order = new HashSet<Order>();
        }

        public int TimeId { get; set; }

        [Required]
        [StringLength(10)]
        public string TimeStart { get; set; }

        [Required]
        [StringLength(10)]
        public string TimeEnd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
