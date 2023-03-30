using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.TopicoAvancados {
    internal class Linq2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 25, Nota = 8.0},
                new Aluno() {Nome = "Juraci", Idade = 10, Nota = 10.0},
                new Aluno() {Nome = "Elaine", Idade = 50, Nota = 6.0},
                new Aluno() {Nome = "Vinicius", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Naruto", Idade = 28, Nota = 7.6},
                new Aluno() {Nome = "Bruinha", Idade = 23, Nota = 10.0},
            };

            //desta forma caso o equals não ache a pesquisa, retornara um erro no compilador.
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}, sua nota foi: {pedro.Nota}");

            //utilizando o singleOrdefault, caso não encontre ele retornara o valor padrão
            var fulano = alunos.SingleOrDefault(
                aluno => aluno.Nome.Equals("Sicrano"));

            if(fulano == null) {
                Console.WriteLine("aluno Inexistente");
            }
        }

    }
}
