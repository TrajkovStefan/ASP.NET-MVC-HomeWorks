using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        //Add Index action that returns a view with a simple html that says “List of orders”. It should be accessed through custom route
        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> orders = StaticDb.Orders;
            return View(orders);
        }
        [Route("OrdersController/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if(id == 0)
            {
                return new EmptyResult();
            }
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if(order == null)
            {
                return new EmptyResult();
            }
            return View(order);
        }
        [Route("OrdersController/JsonData")]
        public IActionResult JsonReturns()
        {
            return new JsonResult(StaticDb.Orders);
        }
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
