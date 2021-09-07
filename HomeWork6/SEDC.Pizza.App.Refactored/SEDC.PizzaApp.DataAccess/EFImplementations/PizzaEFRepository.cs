using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.EFImplementations
{
    public class PizzaEFRepository : IPizzaRepository
    {
        private PizzaAppDbContext _pizzaAppDbContext;
        public PizzaEFRepository(PizzaAppDbContext pizzaAppDbContext)
        {
            _pizzaAppDbContext = pizzaAppDbContext;
        }
        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetAll()
        {
            return _pizzaAppDbContext.Pizzas
                   .Include(x => x.PizzaOrders)
                   .ThenInclude(x => x.Order)
                   .ToList();
        }

        public Pizza GetById(int id)
        {
            //select * from Pizzas
            //where Id = 2
            //return _pizzaAppDbContext.Pizzas.FirstOrDefault(x => x.Id == id);
            return _pizzaAppDbContext.Pizzas
                   .Include(x => x.PizzaOrders)
                   .ThenInclude(x => x.Order)
                   .FirstOrDefault(x => x.Id == id);
        }

        public Pizza GetPizzaOnPromotion()
        {
            return _pizzaAppDbContext.Pizzas.FirstOrDefault(x => x.IsOnPromotion == true);
        }

        public int Insert(Pizza entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza entity)
        {
            throw new NotImplementedException();
        }
    }
}
