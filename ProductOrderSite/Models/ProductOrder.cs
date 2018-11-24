using System;
using System.Collections.Generic;

namespace ProductOrderSite.Models
{
    public class ProductOrder
    {
        public Order Order { get; set; }
        public ICollection<Product> Products { get; set; }

        public ProductOrder(Order order, ICollection<Product> products)
        {
            this.Order = order;
            this.Products = products;
        }
    }
}