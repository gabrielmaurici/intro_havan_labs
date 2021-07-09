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

            while (String.IsNullOrEmpty(dado))
            {
                Console.Write("Você deve informar corretamente os dados, tente novamente: ");
                dado = Console.ReadLine().Trim();
            }
            return dado;
        }
        public static int ValidaInteiro()
        {
            do
            {
                try
                {
                    int numero = Convert.ToInt32(Console.ReadLine());
                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um número corretamente: ");
                }
            } while (true) ;
        }
    }
}
