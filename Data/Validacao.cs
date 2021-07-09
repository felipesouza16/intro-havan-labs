using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Validacao
    {
        public static string ValidaString()
        {
            string dado = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(dado)) // ou (dado.Equals(""))
            {
                Console.WriteLine("Dado inválido. Tente novamente.");
                Console.ReadLine();
            }
            return dado;
        }

        public static int ValidaInt()
        {
            do
            {

                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dado inválido, digite novamente!");
                }

            }
            while (true);
        }
    }
}
