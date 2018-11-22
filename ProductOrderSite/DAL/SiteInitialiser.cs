using ProductOrderSite.Models;
using System;
using System.Collections.Generic;

namespace ProductOrderSite.DAL
{
    public class SiteInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SiteContext>
    {
        protected override void Seed(SiteContext context)
        {
            var customers = new List<Customer>
            {
            new Customer{FirstMidName="Carson",LastName="Alexander",StreetAddress="76 Hill Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Meredith",LastName="Alonso",StreetAddress="24 Rhodes Ave", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Arturo",LastName="Anand",StreetAddress="124 Howick Circle", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Gytis",LastName="Barzdukas",StreetAddress="19 Thirtyfive Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Yan",LastName="Li",StreetAddress="90 Orange Road", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Peggy",LastName="Justice",StreetAddress="48 Noman Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Laura",LastName="Norman",StreetAddress="42 Lifeuniverse Space", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Nino",LastName="Olivetto",StreetAddress="24 Everythingelse Close", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234}
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{Name="Samsung Galaxy Note 7",Description="A Samsung Galaxy Note 7", Price = 12000},
            new Product{Name="Thompsons Coffee Machine",Description="A Thompsons Coffee Machine",Price = 2000},
            new Product{Name="Spier Coffee Machine",Description="A Spier Coffee Machine", Price = 2500},
            new Product{Name="Fitbit",Description= "A fitness tracker", Price = 2500},
            new Product{Name="Bellabeat", Description = "Wellness Tracker", Price = 1500},
            new Product{Name="Winter Is Coming Frost Mug",Description = "Frost Mug", Price = 150},
            new Product{Name="MSI GX70 Destroyer", Description = "MSI Gaming laptop", Price = 20000}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order{CustomerId=1,ProductId=1,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=1,ProductId=2,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=1,ProductId=3,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2,ProductId=4,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2,ProductId=5,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2,ProductId=6,DeliveryDate=DateTime.Parse("2018-12-11")},
            new Order{CustomerId=3,ProductId=7,DeliveryDate=DateTime.Parse("2018-11-19")},
            new Order{CustomerId=3,ProductId=1,DeliveryDate=DateTime.Parse("2018-11-19")},
            new Order{CustomerId=3,ProductId=2,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=5,ProductId=3,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=5,ProductId=4,DeliveryDate=DateTime.Parse("2018-11-30")},
            new Order{CustomerId=5,ProductId=5,DeliveryDate=DateTime.Parse("2005-09-01")},
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}