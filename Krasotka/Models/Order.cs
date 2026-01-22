namespace Krasotka.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDeliviry { get; set; }

        public int? PickupPointId { get; set; }

        public int? UserId { get; set; }

        public int? CodeForGot { get; set; }

        public int? StatusId { get; set; }

        public virtual PickupPoint PickupPoint { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
