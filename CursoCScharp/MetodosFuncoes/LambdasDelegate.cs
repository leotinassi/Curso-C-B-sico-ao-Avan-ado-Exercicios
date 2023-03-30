using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.MetodosFuncoes {

    delegate double Operacao(double x, double y);
    //delegate é um tipo como qualquer outro
    internal class LambdasDelegate {
        public static void Executar() {
            Operacao soma = (x, y) => x + y;

            Console.WriteLine(soma(4, 4));
        }
    }
}
