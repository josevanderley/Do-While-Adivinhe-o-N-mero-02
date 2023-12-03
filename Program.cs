using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Adivinhe_o_Número_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroCorreto = random.Next(1, 101);
            int tentativa, contadorTentativas = 0;

            do
            {
                Console.Write("Digite um número entre 1 e 100: ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                contadorTentativas++;

                if (tentativa == numeroCorreto)
                {
                    Console.WriteLine($"Parabéns! Você acertou em {contadorTentativas} tentativa(s).");
                }
                else if (tentativa < numeroCorreto)
                {
                    Console.WriteLine("Tente um número maior.");
                }
                else
                {
                    Console.WriteLine("Tente um número menor.");
                }

            } while (tentativa != numeroCorreto);
        }
    }
}
    
