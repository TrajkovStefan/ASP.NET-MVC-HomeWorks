using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Pizzas";
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModel = pizzas.Select(x => x.PizzaToPizzaViewModelExtensionMethod()).ToList();
            return View(pizzaViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            PizzaViewModel pizzaViewDetailsModel = PizzaMapper.PizzaToPizzaDetailsViewModel(pizza);
            ViewBag.PizzaViewModel = pizzaViewDetailsModel;
            ViewData["Title"] = "Pizza Details";
            return View();
        }

        [Route("SeePizzas")]
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}