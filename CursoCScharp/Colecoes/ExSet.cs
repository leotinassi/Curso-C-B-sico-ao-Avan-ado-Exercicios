using CursoCScharp.Colecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Colecoes {
    
    }
    internal class ExSet {
        public static void Executar() {

            Produto livro = new Produto("Game of Thrones", 49.9);
            
            //set é uma instrutura não indexada
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro); // adicionei o elemento livro dentro da list (carrinho)

            var combo = new HashSet<Produto> {
            new Produto("Camisa", 29.9),     
            new Produto(" Livro Senhor dos Aneis ", 99.9),     
            new Produto("Laricinha de Adamantio", 10)
            };

            carrinho.UnionWith(combo); // faz a união entre 
            Console.WriteLine(carrinho.Count); // mostrar quantos elementos tem  em um a set
            //carrinho.RemoveAt(3); //set não é indexado então não tem as funções vinculado a indexe

            foreach(var item in carrinho ) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco} ");
            }

        }
    }

