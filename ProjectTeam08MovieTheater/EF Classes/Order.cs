namespace ProjectTeam08MovieTheater.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int MovieId { get; set; }

        public int CustId { get; set; }

        public int TimeId { get; set; }

        public int OrderTicketNum { get; set; }

        public double OrderAmount { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Time Time { get; set; }
    }
}
