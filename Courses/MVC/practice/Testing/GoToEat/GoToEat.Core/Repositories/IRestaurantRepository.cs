using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToEat.Core.Repositories
{
    public interface IRestaurantRepository
    {
        Restaurant GetRestaurantById(int restaurantId);
        List<Restaurant> GetAllRestaurants();
        void Insert(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int restaurantId);
    }
}
