﻿using SEDC.PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "The name of the pizza")]
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal Price { get; set; }
        public string UserAddress { get; set; }
        public bool Delivered { get; set; }
    }
}
