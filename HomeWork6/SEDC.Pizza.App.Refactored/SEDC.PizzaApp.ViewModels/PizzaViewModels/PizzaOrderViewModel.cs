using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaOrderViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int OrderId { get; set; }
        [Display(Name = "Pizza")]
        public int PizzaId { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
    }
}
