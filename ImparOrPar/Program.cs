
namespace ImparOrPar 
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}