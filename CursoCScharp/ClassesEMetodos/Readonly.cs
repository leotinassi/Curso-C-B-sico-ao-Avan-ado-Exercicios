using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; // caso queria inicializar um atributo no construtor porem sera imutavel.

        public Cliente(string nome, DateTime nascimento) {
        Nome = nome;
            Nascimento = nascimento;

        }
        public string GetDataDeNascimento() {
            return String.Format("{0} / {1} / {2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }
    internal class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5,22));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
