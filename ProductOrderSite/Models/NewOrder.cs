using System;
using System.Collections.Generic;

namespace ProductOrderSite.Models
{
    public class NewOrder
    {
        public Order Order { get; set; }
        public ICollection<Product> Products { get; set; }

        public int CustomerId { get; set; }

        public int ProductId { get; set; }
        public DateTime DeliveryDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

        public NewOrder(int customerId, ICollection<Product> products, DateTime deliveryDate)
        {
            this.Products = products;
        }
    }
}