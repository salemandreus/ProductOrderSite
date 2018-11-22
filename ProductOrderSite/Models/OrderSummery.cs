using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductOrderSite.Models
{
    public class OrderSummery
    {
        public Guid Id;
        public int OrderId;
        public Customer Customer;
        public DateTime DeliveryDate;
    }
}