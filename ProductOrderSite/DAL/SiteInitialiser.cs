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
            new Customer{FirstMidName="",LastName="Waltons Stationary Inc",StreetAddress="76 Hill Street", Suburb = "Umhlanga", City = "Durban", PostalCode = 1234},
            new Customer{FirstMidName="",LastName="Waltons Stationary Inc",StreetAddress="24 Rhodes Ave", Suburb = "Grahamstown", City = "Grahamstown", PostalCode = 1234},
            new Customer{FirstMidName="Arturo",LastName="Anand",StreetAddress="124 Howick Circle", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="",LastName="Waltons Stationary Inc",StreetAddress="19 Thirtyfive Street", Suburb = "Claremont", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Yan",LastName="Li",StreetAddress="90 Orange Road", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Peggy",LastName="Justice",StreetAddress="48 Noman Street", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234},
            new Customer{FirstMidName="Laura",LastName="Norman",StreetAddress="42 Lifeuniverse Space", Suburb = "Santon", City = "Johannesburg", PostalCode = 1234},
            new Customer{FirstMidName="Nino",LastName="Olivetto",StreetAddress="24 Everythingelse Close", Suburb = "Tyger Valley", City = "Cape Town", PostalCode = 1234}
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{Name="Samsung Galaxy Note 7",Description="A popular phone model by Samsung", Price = 12000},
            new Product{Name="Thompsons Coffee Machine",Description="A Coffee Machine by Thompsons",Price = 2000},
            new Product{Name="Spier Coffee Machine",Description="A Coffee Machine by Spier", Price = 2500},
            new Product{Name="Fitbit",Description= "A fitness tracker", Price = 2500},
            new Product{Name="Bellabeat Leaf", Description = "A Wellness Tracker which is also jewelery", Price = 1500},
            new Product{Name="Winter Is Coming Frost Mug",Description = "Frost Mug based on Game of Thrones", Price = 150},
            new Product{Name="MSI GX70 Destroyer", Description = "An MSI Gaming laptop", Price = 20000}
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order{OrderId=1,CustomerId=1,ProductId=1,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=1,CustomerId=1,ProductId=2,DeliveryDate=DateTime.Parse("2018-12-13")},
            new Order{OrderId=1,CustomerId=1,ProductId=3,DeliveryDate=DateTime.Parse("2018-12-13")},
            new Order{OrderId=2,CustomerId=2,ProductId=4,DeliveryDate=DateTime.Parse("2018-12-13")},
            new Order{OrderId=2,CustomerId=2,ProductId=5,DeliveryDate=DateTime.Parse("2018-12-13")},
            new Order{OrderId=2,CustomerId=2,ProductId=6,DeliveryDate=DateTime.Parse("2018-12-13")},
            new Order{OrderId=3,CustomerId=3,ProductId=7,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=3,CustomerId=3,ProductId=1,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=3,CustomerId=3,ProductId=2,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=4,CustomerId=5,ProductId=3,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=4,CustomerId=5,ProductId=4,DeliveryDate=DateTime.Parse("2018-12-20")},
            new Order{OrderId=4,CustomerId=5,ProductId=5,DeliveryDate=DateTime.Parse("2018-12-20")},
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
        }
    }
}