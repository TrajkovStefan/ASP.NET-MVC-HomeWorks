using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.FeedbackViewModels
{
    public class FeedbackListViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Feedback Name")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Feedback Message")]
        public string Message { get; set; }
    }
}
