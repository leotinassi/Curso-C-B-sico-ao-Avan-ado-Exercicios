using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {
    internal class DesafioAtributo {

        int a = 10;
        public static void Executar() {

            var acessA = new DesafioAtributo();

            Console.WriteLine("o Valor da variavel é: " + acessA.a);
        }
    }
}
