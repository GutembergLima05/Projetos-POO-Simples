using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOex2
{
    internal class Fucionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            
            SalarioBruto += SalarioBruto / 100 * porcentagem;
            
        }

        public override string ToString()
        {
            return
                Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
