using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }
        
    internal class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1;// Atribuição Por valor
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);
            //o retorno no console vão ser diferentes.


            CPonto ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto copiaPonto2 = ponto2;// Atribuição Por Referencia
            ponto2.X = 3;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
            //o retorno no console sai ser o mesmo.
        }
    }
}
