using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProductOrderSite.Models
{
    public class NewOrder
    {
        public Order Order { get; set; }
        public ICollection<Product> Products { get; set; }

        [DisplayName("Client's Id")]
        public int CustomerId { get; set; }

        [DisplayName("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Delivery Date")]
        public DateTime DeliveryDate { get; set; }

        [DisplayName("Product")]
        public virtual Product Product { get; set; }

        [DisplayName("Client's Name")]
        public virtual Customer Customer { get; set; }

        public NewOrder(int customerId, ICollection<Product> products, DateTime deliveryDate)
        {
            this.Products = products;
        }
    }
}