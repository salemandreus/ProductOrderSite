using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrderSite.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DisplayName("Item Order ID")]
        public Guid Id { get; set; }

        [DisplayName("Order ID")]
        public int OrderId { get; set; }

        [DisplayName("Client's Id")]
        public int CustomerId { get; set; }

        [DisplayName("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Due Delivery Date")]
        public DateTime DeliveryDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
    }
}