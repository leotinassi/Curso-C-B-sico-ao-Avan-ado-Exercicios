using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto() {
        }

        public Produto(string nome, double preco) {
            Nome= nome;
            Preco= preco;
        }
    }
    internal class ExList {
        public static void Executar() {

            Produto livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro); // adicionei o elemento livro dentro da list (carrinho)

            var combo = new List<Produto> {
            new Produto("Camisa", 29.9),     
            new Produto(" Livro Senhor dos Aneis ", 99.9),     
            new Produto("Laricinha de Adamantio", 10)
            };

            carrinho.AddRange(combo); // add todos elemento de uma list vai ser adicionado a ourta
            Console.WriteLine(carrinho.Count); // mostrar quantos elementos tem  em um a lista
            carrinho.RemoveAt(3); // contando do 0 ao 3 removera o ultimo item da lista

            foreach(var item in carrinho ) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco} ");
            }

        }
    }
}
