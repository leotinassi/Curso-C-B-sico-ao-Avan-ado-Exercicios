using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCScharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //Formatando, decimal colocando apenas uma casa apos a virgula 
            Console.WriteLine(valor.ToString("C")); //Formatando com o padrão C, que é padrão da Moeda atual da sua região onde se encontra o PC
            Console.WriteLine(valor.ToString("P")); // Formatando valor percentoal. 
            Console.WriteLine(valor.ToString("#.##")); // funciona como o f1 ou f2 etc o cerquilha também funciona.

            CultureInfo cultura = new CultureInfo("pt-BR"); // instanciei um Obj cultura de cultureinfo com o padrão PT BR.
            Console.WriteLine(valor.ToString("C0", cultura)); // utiliza o padrão que foi imposto no obj criado (cultura)

            int inteiro = 256;
            Console.WriteLine(valor.ToString("D10")); // formatando com zeros a esquerda
        }
    }
}
