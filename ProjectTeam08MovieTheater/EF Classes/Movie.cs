namespace ProjectTeam08MovieTheater.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            Order = new HashSet<Order>();
        }

        public int MovieId { get; set; }

        public int AudiId { get; set; }

        [Required]
        [StringLength(45)]
        public string MovieTitle { get; set; }

        [Column(TypeName = "money")]
        public decimal MoviePrice { get; set; }

        [Required]
        [StringLength(10)]
        public string MovieRate { get; set; }

        public int MovieAgeLimit { get; set; }

        [Required]
        [StringLength(50)]
        public string MovieGenre { get; set; }

        public virtual Auditorium Auditorium { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
