using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProductOrderSite.Models
{
    public class Customer
    {
        [DisplayName("Client's Id")]
        public int Id { get; set; }

        [DisplayName("Surname/ Company")]
        public string LastName { get; set; }

        [DisplayName("First Names")]
        public string FirstMidName { get; set; }

        [DisplayName("Street Address")]
        public string StreetAddress { get; set; }

        [DisplayName("Suburb")]
        public string Suburb { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Postal Code")]
        public int PostalCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}