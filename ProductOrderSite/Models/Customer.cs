using System;
using System.Collections.Generic;

namespace ProductOrderSite.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}