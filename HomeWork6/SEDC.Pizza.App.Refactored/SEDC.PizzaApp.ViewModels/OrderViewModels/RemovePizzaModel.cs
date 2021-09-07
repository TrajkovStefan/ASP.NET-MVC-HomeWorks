using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.OrderViewModels
{
    public class RemovePizzaModel
    {
        //the order we remove from
        public int OrderId { get; set; }
        //the pizza we will remove
        public int PizzaId { get; set; }
    }
}
