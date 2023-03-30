using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            Console.WriteLine(" Possui bom comportamente (S/N): ");
            entrada = Console.ReadLine();

            //if(entrada == "S" || entrada == "s"){
            //    bomComportamento = true;
            //}

            // bomComportamento = entrada == "S" || entrada == "s";  // é apenas uma forma diferente de fazer o mesmo if de cima.

            bomComportamento = entrada.ToLower() == "s"; // utilizando do metodo ToLower pra transformar todas entradas em minusculo.

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("quadro de Honra!");
            }


        }
    }
}
