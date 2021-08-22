using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserDetailsViewModel UserToUserDetailsViewModel(this User user)
        {
            return new UserDetailsViewModel()
            {
                FirstName = $"{user.FirstName}",
                LastName = $"{user.LastName}"
            };
        }

        public static UserSelectViewModel ToUserSelectViewModel(UserSelectViewModel user)
        {
            return new UserSelectViewModel
            {
                Id = user.Id,
                FullName = user.FullName
            };
        }
        internal static object ToUserSelectViewModel(User x)
        {
            throw new NotImplementedException();
        }
    }
}
