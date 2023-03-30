using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCScharp.Fundamentos
{
     class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é seu Nome?: ");
            Console.WriteLine();
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Qual é sua Idade?: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("qual é seu salário?: ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome:{nome}, Idade: {idade}, salário: {salario}");


        }
    }
}
