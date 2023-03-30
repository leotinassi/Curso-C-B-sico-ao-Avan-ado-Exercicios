using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A Area é " + area);
            Console.WriteLine();

            // Tipo internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);
            Console.WriteLine();

            //armazena de zero a 256
            byte idade = 45;

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);
            Console.WriteLine();

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);
            Console.WriteLine();

            int menorValorInt = int.MinValue; //Mais Usado dos inteiros, int padrão pode ter sinal!
            Console.WriteLine("Menor int " + menorValorInt);
            Console.WriteLine();

            uint populacaoBrasileira = 207_600_000; // Uint é sem sinal.
            Console.WriteLine("A população é de: " + populacaoBrasileira);
            Console.WriteLine();

            long menorValorLong = long.MinValue; //long com sinal
            Console.WriteLine("Menor long " + menorValorLong);
            Console.WriteLine();

            ulong populacaoMundial = 7_600_000_000; //sem sinal.
            Console.WriteLine(" A População Mundial é de: " + populacaoMundial);
            Console.WriteLine();

            //OBS SEM SINAL, NUMERO QUE NÃO PODE SER NEGATIVO CONTA DE 0 A 4BI NO CASO DE SER LONG
            // COM SINAL ELE DIVIDE, SERIA 2BI NEGATIVO E 2 BI POSITIVO.

            float precoComputador = 1299.99f; //Float so aceita ser nomeado se tiver o " F " no final, caso contrario ele entende que é double
            Console.WriteLine("Preço do Computador: " + precoComputador);
            Console.WriteLine();

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine(" a distancia entre terra e o sol é: " + distanciaEntreEstrelas);//Decimal é usado apenas quando há necessidade de tamanhos
            Console.WriteLine();
            // Numericos Astronomicos.

            char letra = 'b'; //Utilizado para guardar apenas uma charactere    
            Console.WriteLine("A letra da Vareavel é: " + letra);
            Console.WriteLine();

            string texto = "Seja bem vindo a Festa da Putaria "; // Utilizado quando a necessidade de uma cadeia de charactere.
            Console.WriteLine(" o Texto é: " + texto);
            Console.WriteLine();



        }
    }
}
