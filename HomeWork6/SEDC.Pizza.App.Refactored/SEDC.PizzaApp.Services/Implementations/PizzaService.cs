using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _pizzaRepository;
        public PizzaService(IPizzaRepository pizzaRepository) //Dependency injection
        {
            _pizzaRepository = pizzaRepository;
        }
        public void CreatePizza(PizzaViewModel pizzaViewModel)
        {
            List<Pizza> pizzasDb = _pizzaRepository.GetAll().Where(x => x.IsOnPromotion == true).ToList();
            if(pizzasDb.Count > 1)
            {
                throw new Exception("Only one pizza can be on promotion");
            }
            Pizza pizza = pizzaViewModel.ToPizza();
            int newPizzaId = _pizzaRepository.Insert(pizza);
            if(newPizzaId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }

        public List<PizzaListViewModel> GetAllPizzas()
        {
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            return pizzasDb.Select(x => PizzaMapper.PizzaToPizzaListViewModel(x)).ToList();
        }

        public PizzaDetailsViewModel GetPizzaDetails(int id)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(id);
            if(pizzaDb == null)
            {
                throw new Exception($"The pizza with id {id} is not found!!!");
            }
            return pizzaDb.PizzaDetailsViewModel();
        }

        public List<PizzaDDViewModel> GetPizzasForDropDown()
        {
            //get from db
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            return pizzasDb.Select(x => x.ToPizzaDDViewModel()).ToList();
        }

        public List<PizzaOrderViewModel> GetPizzasForDropDownFromOrder()
        {
            //get from db
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            return pizzasDb.Select(x => x.ToPizzaOrderDDViewModel()).ToList();
        }

        public string GetPizzaOnPromotion()
        {
            return _pizzaRepository.GetPizzaOnPromotion().Name;
        }
    }
}
