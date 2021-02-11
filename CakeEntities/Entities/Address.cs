namespace CakeEntities.Entities
{
    public class Address
    {
        public Address()
        {
        }

        public long Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string FullAddress => $"{City}, {State}, {Country}, {Zip}";
    }
}