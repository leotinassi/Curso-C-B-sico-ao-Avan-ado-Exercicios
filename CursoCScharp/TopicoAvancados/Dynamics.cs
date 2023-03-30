using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.TopicoAvancados {
    internal class Dynamics {
        public static void Executar() {
            dynamic num1 = 100;

            num1 = "Toma uma la nu ba";

            //o tipo dynamic pode ser atribuido varios tipos nela .

            //Dessa forma o obj também é dinamico e pode-se acrescentar atributos de varios tipos a ele.
            dynamic aluno = new System.Dynamic.ExpandoObject();

            aluno.nome = " Maria";
            aluno.nota = 9.0;
            aluno.idade = 27;
        }

    }
}
