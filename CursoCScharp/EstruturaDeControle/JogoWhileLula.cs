using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class JogoWhileLula {
        public static void Executar() {
            string amigoCorno = "gabriel carraro";
            string tentativaresp;
            int tentativasRestantes = 4;
            bool corninEncontrado = false;

            while (tentativasRestantes > 0 && !corninEncontrado) {
                Console.WriteLine("Bem vindo ao Jogo!!!");
                Console.WriteLine("Tente acertar qual dos amigos de Leonardo Tinassi, Foi corno receentemente: ");
                tentativaresp = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine();
                tentativasRestantes--;

                if (tentativaresp == amigoCorno) {
                    corninEncontrado=true;
                    var corAnteriorBackGround = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Voce Acertou meu ultimo amigo corneado que eu saiba é o: {0}", amigoCorno);
                    Console.BackgroundColor = corAnteriorBackGround;

                }else if (tentativasRestantes == 3) {
                    Console.WriteLine("talvez esteja muito dificil, irei te dar uma dica!");
                    Console.WriteLine("Ele Tem medo de borboleta, mas tem uma desenhada em alguma parte de seu corpo...");
                    Console.WriteLine();
                    Console.WriteLine();

                }else if (tentativasRestantes == 2) {
                    Console.WriteLine("Hmm... Continua hard ?, então a proxima dica é, Ele beija rapazes... ");
                    Console.WriteLine();
                    Console.WriteLine();

                } else if (tentativasRestantes == 1) {
                    Console.WriteLine(" Krl de é Badola hein !!!! Não acertou ainda, ruim do kct");
                    Console.WriteLine("Ultima dica é, tem tolerancia a lactose ");
                    Console.WriteLine();

                }
            }

        }
    }
}
