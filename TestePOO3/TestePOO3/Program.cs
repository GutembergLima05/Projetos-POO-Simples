using System.Globalization;
using TestePOO3;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1;
            p1 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantide no Estoque: ");
            p1.Qntd = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p1);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado do estoque");
            int qte = int.Parse(Console.ReadLine());

            p1.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p1);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removido do estoque");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);
            Console.Write("Dados atualizados: " + p1);


        }
    }
}