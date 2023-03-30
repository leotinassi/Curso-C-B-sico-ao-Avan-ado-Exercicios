﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine("{0} É o numero que queremos? ", i);

                if(i == numero) {
                    Console.WriteLine("Sim! ");
                    break; // serve para sair do laço de repetição.
                }else {
                    Console.WriteLine("Não! ");
                }
            }
            Console.WriteLine("Fim!, o Numero foi encontrado ");
        }
    }
}
