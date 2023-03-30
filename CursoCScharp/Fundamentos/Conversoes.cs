using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;//Houve uma conversão porem um inteiro cabe sem problemas dentro de um double, não foi preciso fazer nada.

            double nota = 9.7;
            int notaTruncada = (int) nota; //Houve uma conversão porem teve que ser explicita pois inteiro n comporta decimal, sendo assim
            // Tira-ra a casa decimal do numero, restando apenas "nota: 9"
            //Lembrando que é preciso conversão explicita quando há  uma possivilidade de perda de informação.
            Console.WriteLine("Nota Truncada: {0}" + nota);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); //forma de converter String para numero inteiro
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString); //conversão utilizando Classe convert
            Console.WriteLine("resultado: {0} ", idadeInteiro);

            Console.WriteLine("Digite um número ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // é uma forma mais segura de conversão onde ele vai tentar fazera  conversão
            //caso não consiga passara 0 ao invez de dar algum erro na tela.
            Console.WriteLine("Resultado: {0}", numero);

            //Otimizando o Codigo a cima 

            Console.WriteLine("Digite um segundo numero:  ");
            int.TryParse(Console.ReadLine(), out int numero2); 
            Console.WriteLine("Resultado: {0}", numero2);

        }
    }
}
