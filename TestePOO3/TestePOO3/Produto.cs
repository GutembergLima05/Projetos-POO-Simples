using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO3
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Qntd;

        public double ValorTotalEmEstoque()
        {
            return Preco * Qntd;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qntd += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qntd -= quantidade;
        }

        public override string ToString()
        {
            return 
                Nome 
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qntd
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
