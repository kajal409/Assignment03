using OrderEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderAPI.Services
{
    public class OrderService
    {
        public IEnumerable<Order> GetOrders(long? id = null)
        {
            var orders = new List<Order>();
            var ck = GetRestaurants();
            if (id != null)
            {
                ck = ck.Where(r => r.RestaurantId == id);
            }
            foreach (var restaurant in ck)
            {
                for (int i = 1; i <= 3; i++)
                {
                    orders.Add(new Order
                    {
                        Id = i,
                        Number = $"{restaurant.Name}_OrderNumber_{i}",
                        Amount = (double)i * 4.96,
                        Cake = $"Food_{i}",
                        CakeId = i,
                        PlaceOn = DateTime.Now.AddMinutes(i * (-10)),
                        Quantity = i,
                        CustomerId = restaurant.RestaurantId
                    });
                }
            }
            return orders;
        }

        private IEnumerable<Customer> GetRestaurants()
        {
            var c = new List<Customer>();
            for (int i = 1; i <= 3; i++)
            {
                c.Add(new Customer
                {
                    Id = i,
                    RestaurantId = i,
                    Name = $"Cake_{i}",
                    Address = $"Address_{i}"
                });
            }
            return c;
        }
    }
}
