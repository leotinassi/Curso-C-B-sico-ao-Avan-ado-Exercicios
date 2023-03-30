using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Colecoes {
    internal class ExArray {
        public  static void Executar() {
            string[] alunos = new string[5]; // Array no C# é homogenio e statico, não é dinamico.
            alunos[0] = "Anderson";
            alunos[1] = "Juraci";
            alunos[2] = "Carlos";
            alunos[3] = "Dunha";
            alunos[4] = "Tiago";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
           
            Console.WriteLine(media);
        }
    }
}
