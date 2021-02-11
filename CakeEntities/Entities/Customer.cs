namespace CakeEntities.Entities
{
    public class Customer
    {
        public Customer()
        {
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public Address Address { get; set; }
    }
}
