using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {
    internal class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(int numero) {
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a); //passado por referencia, sera alterada porem não sumira o que ja tinha na variavel
            Console.WriteLine(a);

            int b = 2;
            AlterarOut(b);
            Console.WriteLine(b);

        }
    }
}
