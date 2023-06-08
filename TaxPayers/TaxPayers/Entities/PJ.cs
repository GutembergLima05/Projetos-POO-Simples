
namespace TaxPayers.Entities
{
    class PJ : Person
    {
        public int Employee { get; set; }

        public PJ(string name, double renda, int employee) : base (name, renda)
        {
            Employee = employee;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if (Employee > 10)
            {
                return Renda * 0.14;
            } else
            {
                return Renda * 0.16;
            }
        }
       
    }
}
