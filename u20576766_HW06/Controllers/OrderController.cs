using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u20576766_HW06.Models;
using PagedList.Mvc;
using PagedList;

namespace u20576766_HW06.Controllers
{
    public class OrderController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Order
        public ActionResult Orders(DateTime? search, int? tale)
        {
            List<order_items> orderI = db.order_items.ToList();
            return View(db.order_items.Where(x => x.order.order_date == search || search == null).ToList().ToPagedList(1, 10));
           
        }
    }
}