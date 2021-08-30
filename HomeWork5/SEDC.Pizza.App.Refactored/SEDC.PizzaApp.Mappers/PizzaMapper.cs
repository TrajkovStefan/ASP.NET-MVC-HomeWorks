using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaListViewModel PizzaToPizzaListViewModel(Pizza pizza)
        {
            return new PizzaListViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaDetailsViewModel PizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static Pizza ToPizza(this PizzaViewModel pizzaViewModel)
        {
            return new Pizza
            {
                Id = pizzaViewModel.Id,
                Name = pizzaViewModel.Name,
                Price = pizzaViewModel.Price,
                IsOnPromotion = pizzaViewModel.IsOnPromotion
            };
        }

        public static PizzaDDViewModel ToPizzaDDViewModel(this Pizza pizza)
        {
            return new PizzaDDViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name
            };
        }
    }
}
