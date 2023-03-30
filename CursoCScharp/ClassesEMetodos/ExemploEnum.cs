using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {
    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum {

        public static void Executar() {
            int id = (int)Genero.Animacao; // fiz a conversão de um enum para inteiro e taquei na variavel id
            Console.WriteLine(id);// essa conversão vai me mostrar a posição em que esta o indice animação.

            var filmeParaFamilia = new Filme();

            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo,
                filmeParaFamilia.GeneroDoFilme);
        }
    }

}
