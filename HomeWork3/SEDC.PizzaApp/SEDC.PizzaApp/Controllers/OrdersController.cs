using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
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
            List<Order> ordersDb = StaticDb.Orders;
            List<OrderListViewModel> orderListViewModels = ordersDb.Select(x => OrderMapper.OrderToOrderListViewModel(x)).ToList();
            //List<OrderListViewModel> orderListViewModels = new List<OrderListViewModel>();
            //foreach(Order orderDb in ordersDb)
            //{
            //    orderListViewModels.Add(OrderMapper.OrderToOrderDetailsViewModel(orderDb));
            //}

            //ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Message"] = StaticDb.Message;
            ViewData["Title"] = "Orders list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            ViewData["FirstUser"] = StaticDb.Users.First();

            return View(orderListViewModels);
        }
        [Route("Orders/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if(id == 0)
            {
                return new EmptyResult();
            }
            //ViewBag.Message = "You are on the order details page";
            ViewData["Message"] = StaticDb.Message;
            ViewBag.User = StaticDb.Users.First();
            //orderDb -> DB
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if(orderDb == null)
            {
                return View("ResourceNotFound"); //first look in Order folder, then in Shared
            }
            //view model -> data to the view
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
        public IActionResult CreateOrder()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            ViewBag.Users = StaticDb.Users.Select(x => UserMapper.ToUserSelectViewModel(x)).ToList();
            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel orderViewModel)
        {
            orderViewModel.Id = StaticDb.Orders.Last().Id + 1;
            User userDb = StaticDb.Users.FirstOrDefault(x => x.Id == orderViewModel.UserId);
            if(userDb == null)
            {
                return View("ResourceNotFound");
            }
            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Name == orderViewModel.PizzaName);
            if(pizzaDb == null)
            {
                return View("ResourceNotFound");
            }

            StaticDb.Orders.Add(OrderMapper.ToOrder(orderViewModel));
            return RedirectToAction("Index");
        }
        public IActionResult EditOrder(int? id)
        {
            if(id == null)
            {
                return View("Bad Request");
            }
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if(orderDb == null)
            {
                return View("Bad Request");
            }
            ViewBag.Users = StaticDb.Users.Select(x => UserMapper.ToUserSelectViewModel(x)).ToList();
            OrderViewModel orderViewModel = OrderMapper.OrderToOrderViewModel(orderDb);
            return View(orderViewModel);
        }
        [HttpPost]
        public IActionResult EditOrder(OrderViewModel orderViewModel)
        {
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == orderViewModel.Id);
            if(orderDb == null)
            {
                return View("ResourceNotFound");
            }
            User userDb = StaticDb.Users.FirstOrDefault(x => x.Id == orderViewModel.UserId);
            if (userDb == null)
            {
                return View("ResourceNotFound");
            }
            Pizza pizzaDb = StaticDb.Pizzas.FirstOrDefault(x => x.Name == orderViewModel.PizzaName);
            if (pizzaDb == null)
            {
                return View("ResourceNotFound");
            }
            StaticDb.Orders.FirstOrDefault(x => x.Id == orderViewModel.Id).PaymentMethod = orderViewModel.PaymentMethod;
            StaticDb.Orders.FirstOrDefault(x => x.Id == orderViewModel.Id).Delivered = orderViewModel.Delivered;
            StaticDb.Orders.FirstOrDefault(x => x.Id == orderViewModel.Id).User = userDb;
            StaticDb.Orders.FirstOrDefault(x => x.Id == orderViewModel.Id).Pizza = pizzaDb;

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == 0)
            {
                return new EmptyResult();
            }
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound"); //first look in Order folder, then in Shared
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
        [Route("Orders/JsonData")]

        public IActionResult ConfirmDelete(int? id)
        {
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound");
            }
            StaticDb.Orders.Remove(orderDb);
            return RedirectToAction("Index");
        }
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
