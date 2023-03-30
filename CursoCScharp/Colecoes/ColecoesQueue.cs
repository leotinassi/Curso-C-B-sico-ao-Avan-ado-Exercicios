using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Colecoes {
    internal class ColecoesQueue {

        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.Write(fila.Peek());// mostra o primeiro da fila
            Console.Write(fila.Count());// conta quantos tem

            Console.Write(fila.Dequeue());// tira a primeira pessoa da fila
            Console.Write(fila.Count());

            foreach(var pessoa in fila) {
                Console.Write(pessoa);
            }

            var salada = new Queue(); // fila sem generic

            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.Write(salada.Contains("item"));
        }

    }
}
