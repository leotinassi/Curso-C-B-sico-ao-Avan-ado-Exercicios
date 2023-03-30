using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.TopicoAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    internal class Linq {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 25, Nota = 8.0},
                new Aluno() {Nome = "Juraci", Idade = 10, Nota = 10.0},
                new Aluno() {Nome = "Elaine", Idade = 50, Nota = 6.0},
                new Aluno() {Nome = "Vinicius", Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Naruto", Idade = 28, Nota = 7.6},
                new Aluno() {Nome = "Bruinha", Idade = 23, Nota = 10.0},
            }; 
            
            Console.WriteLine(" == Aprovados ================");

            //O Linq nada mais nada menos que codigos com uma sintaxe parecida com SQL
            // nesse codigo a baixo, passei duas expressão lambdas dentro do where, 
            // uma que vai fazer o criterio de preenchimento da lista (aprovados)
            // a outra lambda  ordenara a lista pelo OrderBy, por norme.
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome);

            //um foreach para percorrer a lista.
            foreach( var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("== Lista de Presença============");

            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            //Olhe com atenção, a partir do momento que  dei o select no obj a que é referencia do obj alunos
            // eu converti o obj em uma string sendo assim o for earch eu posso chamar aluno diretamente e não aluno.Nome
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);

            }

            Console.WriteLine("Aprovados novamente fodasse===============");

            //Ja dessa forma  também há o mesmo resultado da primeira vez criado porem com a estrutura mais parecida com
            //sql porem ainda efetuando a conversão do obj para strign.
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach(var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }

        }
    }
}
