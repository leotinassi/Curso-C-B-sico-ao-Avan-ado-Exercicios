using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Orientacao_a_Obj {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro() {
        }

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;
            if(novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if(novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public  virtual int Acelerar() { // virtual é o comando que eu autorizo o metodo ser sobreescrito 
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }
    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {
            
        }
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //ira ocultar médoto da classe Mãe
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    internal class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno Carro1 = new Uno();
            Console.WriteLine(Carro1.Acelerar());
            Console.WriteLine(Carro1.Acelerar());
            Console.WriteLine(Carro1.Frear());
            Console.WriteLine(Carro1.Frear());
            Console.WriteLine(Carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari Carro2 = new Ferrari();
            Console.WriteLine(Carro2.Acelerar());
            Console.WriteLine(Carro2.Acelerar());
            Console.WriteLine(Carro2.Frear());
            Console.WriteLine(Carro2.Frear());
            Console.WriteLine(Carro2.Frear());
        }
    }
}
