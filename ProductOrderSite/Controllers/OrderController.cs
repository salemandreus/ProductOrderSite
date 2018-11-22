using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using ProductOrderSite.DAL;
using ProductOrderSite.Models;

namespace ProductOrderSite.Controllers
{
    public class OrderController : Controller
    {
        private SiteContext db = new SiteContext();

        // GET: Order
        public ActionResult Index()
        {
            var orders = (from o in db.Orders
                          select new OrderSummery
                          {
                              Id = o.Id,
                              OrderId = o.OrderId,
                              Customer = o.Customer,
                              DeliveryDate = o.DeliveryDate
                          });

            return View(orders.DistinctBy(o => o.OrderId).ToList<OrderSummery>());
        }

        // GET: Order/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Order orderIdRef = db.Orders.Find(id);
            if (orderIdRef == null)
            {
                return HttpNotFound();
            }
            IEnumerable<Order> order = db.Orders.Where(o => o.OrderId == orderIdRef.OrderId);

            int[] productIds = order.Select(r => r.ProductId).ToArray();

            IEnumerable<Product> products = db.Products.Where(p => productIds.Contains(p.Id));

            ProductOrder model = new ProductOrder(order.First(), products.ToList());
            return View(model);
        }

        [HttpPost]
        public ActionResult Add_Product([Bind(Include = "Id,CustomerId,ProductId,DeliveryDate")] Order order)
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "LastName", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", order.ProductId);
            return View(order);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "LastName");
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name");
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,Products,DeliveryDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.Id = Guid.NewGuid();
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index", "Order");
            }

            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "LastName", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", order.ProductId);
            return View(order);
        }

        // GET: Order/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "LastName", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", order.ProductId);
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerId,ProductId,DeliveryDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerId = new SelectList(db.Customers, "Id", "LastName", order.CustomerId);
            ViewBag.ProductId = new SelectList(db.Products, "Id", "Name", order.ProductId);
            return View(order);
        }

        // GET: Order/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}