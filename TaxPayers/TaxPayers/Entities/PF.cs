using System.Diagnostics.CodeAnalysis;
using TaxPayers.Entities;

namespace TaxPayers.Entities
{
     class PF : Person
    {
        public double Health { get; set; }

        public PF(string name, double renda,double health) : base(name,renda)
        {
            Health = health;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if (Renda < 20000.00)
            {
                return Renda * 0.15 - Health * 0.5;
            } else
            {
                return Renda * 0.25 - Health * 0.5;
            }

        }

    }
}
