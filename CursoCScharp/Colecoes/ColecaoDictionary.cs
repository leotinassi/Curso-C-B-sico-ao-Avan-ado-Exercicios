using CursoCScharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Colecoes {
    internal class ColecaoDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>(); //  chave, valor, na chave não aceita repetição  

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "miranha");
            filmes.Add(2004, "O grande mestre");

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine($"Removeu {filmes.Remove(2004)}"); //console vai mostar o filme ja removido, com metodo Remove

            //formas de percorer um dictionary
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave); // dessa forma ele percorre só pelas chaves mostrando as.
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor); // Percorrendo pelo valor
            }

            foreach (KeyValuePair<int, string> filme in filmes) 
                { 
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach( var film in filmes) {
                Console.WriteLine($"{film.Value} é de {film.Key}");
            }
        }
    }
}
