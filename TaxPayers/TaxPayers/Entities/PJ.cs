
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
                sum = Renda * 0.14;
            } else
            {
                sum = Renda * 0.16;
            }

            Total = sum;
            return sum;
        }
       
    }
}
