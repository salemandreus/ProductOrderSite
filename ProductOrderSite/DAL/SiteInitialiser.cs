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
            new Customer{Id= 123567,FirstMidName="Carson",LastName="Alexander",StreetAddress="76 Hill Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id= 123567,FirstMidName="Meredith",LastName="Alonso",StreetAddress="24 Rhodes Ave", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=2987,FirstMidName="Arturo",LastName="Anand",StreetAddress="124 Howick Circle", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=2987,FirstMidName="Gytis",LastName="Barzdukas",StreetAddress="19 Thirtyfive Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=2367,FirstMidName="Yan",LastName="Li",StreetAddress="90 Orange Road", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=34567,FirstMidName="Peggy",LastName="Justice",StreetAddress="48 Noman Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=44567,FirstMidName="Laura",LastName="Norman",StreetAddress="42 Lifeuniverse Space", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{Id=44567,FirstMidName="Nino",LastName="Olivetto",StreetAddress="24 Everythingelse Close", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234}
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{Id=1050,Name="Samsung Galaxy Note 7",Description="A Samsung Galaxy Note 7", Price = 12000},
            new Product{Id=4022,Name="Thompsons Coffee Machine",Description="A Thompsons Coffee Machine",Price = 2000},
            new Product{Id=4041,Name="Spier Coffee Machine",Description="A Spier Coffee Machine", Price = 2500},
            new Product{Id=1045,Name="Fitbit",Description= "A fitness tracker", Price = 2500},
            new Product{Id=3141,Name="Bellabeat", Description = "Wellness Tracker", Price = 1500},
            new Product{Id=2021,Name="Winter Is Coming Frost Mug",Description = "Frost Mug", Price = 150},
            new Product{Id=2042,Name="MSI GX70 Destroyer", Description = "MSI Gaming laptop", Price = 20000}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order{CustomerId=123567,ProductId=1050,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=123567,ProductId=4022,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=123567,ProductId=4041,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2987,ProductId=1045,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2987,ProductId=3141,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=2367,ProductId=2021,DeliveryDate=DateTime.Parse("2018-12-11")},
            new Order{CustomerId=34567,ProductId=1050,DeliveryDate=DateTime.Parse("2018-11-19")},
            new Order{CustomerId=44567,ProductId=1050,DeliveryDate=DateTime.Parse("2018-11-19")},
            new Order{CustomerId=44567,ProductId=2021,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=53453,ProductId=2021,DeliveryDate=DateTime.Parse("2005-09-01")},
            new Order{CustomerId=634234,ProductId=2021,DeliveryDate=DateTime.Parse("2018-11-30")},
            new Order{CustomerId=72423,ProductId=2021,DeliveryDate=DateTime.Parse("2005-09-01")},
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}