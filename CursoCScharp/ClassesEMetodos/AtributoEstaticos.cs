using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    public class Produtos {
        public string Nome;
        public double Preco;
        public  static double Desconto = 0.5;
        public Produtos(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produtos() {

        }
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }

    
    internal class AtributoEstaticos {
        public static void Executar() {
            var produto1 = new Produtos("Caneta", 3.2, 0.1);

            var produto2 = new Produtos() {
                Nome = "Cachaça",
                Preco = 50.0,
                
            };
            //uma vez em que o Atributo é statico, nem uma stancia tem seu proprio, e sim é o da classe porem compartilhado.
            Produtos.Desconto = 0.6;

            Console.WriteLine("Preço com desconto: {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}",
                produto2.CalcularDesconto());
        }
    }
}
