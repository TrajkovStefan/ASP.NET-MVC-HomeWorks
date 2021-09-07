using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSizeEnum PizzaSize { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
