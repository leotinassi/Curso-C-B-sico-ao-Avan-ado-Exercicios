using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) 
            { return a * b; }
    }
    internal class MetodosStaticos {
        public static void Executar() {

            // quando o metodo esta static basicamente eu não preciso instanciar um obj para usar o metodo
            // eu posso utilizado direto uma vez que ele fica apenas vinculado a classe
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
