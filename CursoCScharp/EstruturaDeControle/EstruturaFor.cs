using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle {
    internal class EstruturaFor {
        public static void Executar() {

            //int i = 1;
            // while(i <= 10) {
            //    Console.WriteLine("o valor de I é: " +i);
            //}

            //for(int i = 1; i <=10; i++) {
            //    Console.WriteLine("O valor de I é: " + i);
            //} // apenas um exemplo simples, de como fazer com for

            double somatorio = 0;
            string entrada;
            Console.WriteLine("informe o tamanho da turma: ");
            entrada = Console.ReadLine(); ;
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i<= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}: ", 1);
                entrada= Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma: 0;
            Console.WriteLine("Media da turma é: " + media);
        }
    }
}
