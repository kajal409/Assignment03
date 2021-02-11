using CakeEntities.Entities;
using CakeEntities.Enum;
using System.Collections.Generic;

namespace CakeAPI.Services
{
    public class CakeServices
    {
        public List<Cake> GetCake()
        {
            var cakes = new List<Cake>();
            for (int i = 1; i <= 7; i++)
            {
                cakes.Add(new Cake
                {
                    Id = i,
                    Name = $"Cake_{i}",
                    Type = CakeEnum.Vanilla,
                });
            }
            return cakes;
        }
    }
}
