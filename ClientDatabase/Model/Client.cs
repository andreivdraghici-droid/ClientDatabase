namespace ClientDatabase.Model
{
    public class Client
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }
        public int Phone { get; set; }
        
        public Client(string name, string password, string email, string address, string city, int postcode, int phone)
        {
            Name = name;
            Password = password;
            Email = email;
            Address = address;
            City = city;
            Postcode = postcode;
            Phone = phone;
        }
    }
}
