using CakeEntities.Entities;
using System.Collections.Generic;

namespace CakeAPI.Services
{
    public class CustomerServices
    {
        public List<Customer> GetRestaurants()
        {
            var restaurants = new List<Customer>();
            for (int i = 1; i <= 7; i++)
            {
                restaurants.Add(new Customer
                {
                    Id = i,
                    Name = $"Username_{i}",
                    Email = $"Email_{i}",
                    Contact = $"Contact_{i}",
                    Address = new Address
                    {
                        Id = i,
                        City = $"City_{i}",
                        State = $"State_{i}",
                        Zip = $"Zip_{i}",
                        Country = $"Country_{i}"
                    },
                });
            }
            return restaurants;
        }
    }
}
