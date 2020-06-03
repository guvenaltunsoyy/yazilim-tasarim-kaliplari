namespace AdapterPattern
{
    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }

        public Address(string city, string state, string country, string street, int zipCode)
        {
            City = city;
            State = state;
            Country = country;
            Street = street;
            ZipCode = zipCode;
        }
    }
}