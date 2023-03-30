using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class EstruturaWhile {
        public static void Executar(){
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu Palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnteriorBackGround = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero encontrado em {0} Tentativas",
                        tentativas);
                    Console.BackgroundColor = corAnteriorBackGround;
                } else if(palpite > numeroSecreto) {
                    Console.WriteLine(" O valor é Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                } else {
                    Console.WriteLine("O Valor é Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}
