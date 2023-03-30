using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Orientacao_a_Obj {

    public class Comida {
        public double Peso;

        public Comida() {
        }

        public Comida(double peso) {
            Peso = peso;
        }
    }

    public class Feijao : Comida {
        
    }

    public class Arroz : Comida {
        
    }
    public class Carne : Comida {
        
    }
    public class Pessoa : Comida {
        

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}
        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }


    internal class Polimorfismo {
        public static void Executar() {

            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Peso = 85.0;
            Console.WriteLine("Antes de comer o peso é: " + pessoa1.Peso);

            pessoa1.Comer(ingrediente1);
            pessoa1.Comer(ingrediente2);
            pessoa1.Comer(ingrediente2);
            pessoa1.Comer(ingrediente3);

            Console.WriteLine($"O peso atual pos refeição é de {pessoa1.Peso} Kg!");
        }
    }
}
