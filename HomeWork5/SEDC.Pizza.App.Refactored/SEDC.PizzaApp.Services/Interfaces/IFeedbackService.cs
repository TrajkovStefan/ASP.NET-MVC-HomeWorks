using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IFeedbackService
    {
        List<FeedbackListViewModel> GetAllFeedbacks();
        FeedbackDetailsViewModel GetFeedbackDetails(int id);
        void CreateFeedback(FeedbackViewModel feedbackViewModel);
        void EditFeedback(FeedbackViewModel feedbackViewModel);
        FeedbackViewModel GetFeedbackForEditing(int id);
        void DeleteFeedback(int id);
    }
}
