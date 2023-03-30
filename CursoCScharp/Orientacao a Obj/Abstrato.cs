using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Orientacao_a_Obj {

    //A partir de o momento que uma classe é abstrata ela não pode ser mais instanciada
    //Pois so sera instanciada uma classe (Concreta)
    //Qual o Motivo de criar uma classe abstrata ?, quando precisasse de uma classe generica e herdara uma concreta ex.
    //Celular é um conceito abstrato pois em sua mão sempre tera um porem de uma marca especifica
    // iphone, samsung e etc...
    public abstract class Celular {
        public abstract string Assistente();//um medoto abstrato não precisa ser implementado no corpo da criação
        //a implementação do mesmo so sera necessaria se alguma classe concreta herdar (celular) então a obrigação da implementação sera ativa.
        //Ex Real, Celular é uma classe abstrata, todos os celulares tem uma assistente virtual, porem cada marca, tem sua assistente.

        public string Tocar() {
            return "Trim trim trim...";
        }

    }

    public class Sambung : Celular {
        public override string Assistente() {
            return "Ola, eu sou a Bixby";
        }
    }

    internal class Abstrato {
        public static void Executar() {
            var celulares = new List<Celular> {
                new Sambung()
            };

            foreach (var c in celulares) {
                Console.WriteLine(c.Assistente());
            }


        }
    }
}
