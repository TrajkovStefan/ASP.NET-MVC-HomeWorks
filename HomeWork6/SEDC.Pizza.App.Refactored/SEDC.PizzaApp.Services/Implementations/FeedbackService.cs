using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.Shared.CustomExceptions;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IRepository<Feedback> _feedbackRepository;
        public FeedbackService(IRepository<Feedback> feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public List<FeedbackListViewModel> GetAllFeedbacks()
        {
            List<Feedback> feedbacksDb = _feedbackRepository.GetAll();
            return feedbacksDb.Select(x => FeedbackMapper.FeedbackToFeedbackListViewModel(x)).ToList();
        }
        public void CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.ToFeedback()).Email).ToList();
            if(feedbacks.Count == 3)
            {
                throw new Exception("Only 3 feedbacks allowed per e-mail");
            }
            Feedback feedback = feedbackViewModel.ToFeedback();
            int newFeedbackId = _feedbackRepository.Insert(feedback);
            if(newFeedbackId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }
        public void EditFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(feedbackViewModel.Id);
            if(feedbackDb == null)
            {
                throw new Exception($"The feedback with id {feedbackViewModel.Id} was not found!");
            }
            Feedback editedFeedback = feedbackViewModel.ToFeedback();
            editedFeedback.Id = feedbackViewModel.Id;
            editedFeedback.NewFeedback = feedbackDb;
            _feedbackRepository.Update(editedFeedback);
        }
        public void DeleteFeedback(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new Exception($"The feedback with id {id} was not found!");
            }
            _feedbackRepository.DeleteById(id);
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if(feedbackDb == null)
            {
                throw new Exception($"The feedback with id {id} was not found");
            }
            return feedbackDb.FeedbackDetailsViewModel();
        }
        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedbackDb = _feedbackRepository.GetById(id);
            if (feedbackDb == null)
            {
                throw new ResourceNotFoundException($"The order with id {id} was not found");
            }
            //return mapped view model
            return feedbackDb.ToFeedbackViewModel();
        }
    }
}
