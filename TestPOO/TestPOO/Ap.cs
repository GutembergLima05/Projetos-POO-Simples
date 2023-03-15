
namespace TestPOO
{
    internal class Ap
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
