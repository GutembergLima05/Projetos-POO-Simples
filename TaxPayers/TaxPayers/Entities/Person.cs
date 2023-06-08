namespace TaxPayers.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double Renda { get; set; }
        public Person(string name, double renda)
        {
            Name = name;
            Renda = renda;
        }
        public abstract double Tax();
        
    }
}
