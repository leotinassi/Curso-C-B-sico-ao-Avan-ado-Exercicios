using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.MetodosFuncoes {
    internal class Exemplo_Lambda {
        public static void Executar() {
            //Lambda = Função Anonima 
            // "algoNoConsole é a variavel onde esta sendo salva a "funçao anonima"
            //todo Action Obrigatoriamente não tera Retorno.
            // ja o Func tem retorno
            //action sempre poderar receber o parametro, mas o retorno sera void
            Action algoNoConsole = () => {
                Console.WriteLine("Isso aqui  é uma Lambda!! em C#");
            }; 
            
            algoNoConsole();

            //no caso de ter apenas um, 
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1,7);
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234)) ;

            //na Func o ultimo "parametro" é o Retorno da função
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
