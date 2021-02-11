using CakeEntities.Enum;

namespace CakeEntities.Entities
{
    public class Cake
    {
        public Cake()
        {
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public CakeEnum Type { get; set; }
        public string TypeName => Type.ToString();
    }
}