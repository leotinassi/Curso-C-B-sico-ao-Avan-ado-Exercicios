using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class EstruturaDoWhile {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual o seu Nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo " + entrada);
                Console.WriteLine("Deseja continuar ? (S/N)");
                entrada = Console.ReadLine();
            }while(entrada.ToLower() == "s");
        }
    }
}
