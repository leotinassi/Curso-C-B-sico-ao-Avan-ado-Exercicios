using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set { 
                nome = value; }
        }

        //propriedade autoimplementada
        public double Preco { get; set; }

        // Exemplo de Get apenas para Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Lambda Expretion

            //ou também
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Props {
        public static void Executar() {

            var op1 = new CarroOpcional("Ar condicionado", 3995.0);
            Console.WriteLine(op1.PrecoComDesconto);
        }
    }
}
