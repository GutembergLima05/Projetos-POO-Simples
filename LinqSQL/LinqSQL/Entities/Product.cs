namespace LinqSQL.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Email { get; set; }

        public Product(string name, double price, string email)
        {
            Name = name;
            Price = price;
            Email = email;
        }
    }
}
