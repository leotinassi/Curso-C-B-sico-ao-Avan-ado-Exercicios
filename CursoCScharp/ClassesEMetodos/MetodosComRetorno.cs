using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    //exemplo de uma calculadora em cadeia
    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado() {
            return memoria;
        }
    }
    
    // exemplo de uma calculadora comun
    class CalculadoraComun {
        public int Somar(int a, int b) {
            return a + b;

        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }
    internal class MetodosComRetorno {
        public static void Executar() {

            var calculadoraComum = new CalculadoraComun();

            //instanciando e utilizando calculadora comum
            var resultado = calculadoraComum.Multiplicar(5, 5);
            Console.WriteLine("A multiplicação do Resultado foi: " + resultado);
             
            //Instanciando e utilizando calculadora em cadeia.
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(5).Multiplicar(50).Imprimir().Limpar();
        }

    }
}
