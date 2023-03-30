using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {
    internal class Pessoa {

        //Lembrando que quando nomear atributos é utilizado paschoal case, primeira letra MAIUSCULA
        //obs ja em variaveis dentro de metodos, utilzia a criação com a inicial minuscula
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Ola! Me chamo {Nome} e tenho {Idade} anos. ");
        }

        //exemplo de um metodo sem retorno "VOID"

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

    }
}
