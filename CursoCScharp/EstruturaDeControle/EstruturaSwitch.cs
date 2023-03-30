using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimendo com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Bom");
                    break;
                case 4:
                    Console.WriteLine("Otimo");
                    break;
                case 5:
                    Console.WriteLine("Excelente");
                    break;
                default:
                    Console.WriteLine("Nota Invalida!");
                    break;

            }
            Console.WriteLine("Obrigado por votar!!");
        }
    }
}
