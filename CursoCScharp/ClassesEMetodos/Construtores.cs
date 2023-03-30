using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.ClassesEMetodos {

    class Carro {
        public string Fabricante;
        public string Modelo;
        public int Ano;

        //Contrutor recebendo parametros
        public Carro(string fabricante, string modelo, int ano) {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;

        }
        //Construtor padrão criado novamente.
        public Carro(){

        }

    }
    internal class Construtores {
        public static void Executar() {
            Carro carro1 = new Carro();

            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2023;
            Console.WriteLine($"O fabricante deste carro é {carro1.Fabricante}, modelo, {carro1.Modelo}" +
                $"ano, {carro1.Ano}");

            Carro carro2 = new Carro("Mercedez", "C85", 2023);
            Console.WriteLine($"O fabricante deste carro é {carro2.Fabricante}, modelo, {carro2.Modelo} " +
                $"ano {carro2.Ano}");
        }
    }
}
