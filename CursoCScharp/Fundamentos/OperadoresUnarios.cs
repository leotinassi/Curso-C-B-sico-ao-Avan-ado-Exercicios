using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //Ira colocar o contrario
            Console.WriteLine(!booleano);// Negando invertendo o que esta dentro

            num1++; //acrescentando 1
            Console.WriteLine(num1);

            --num1; //decrementando -1
            Console.WriteLine(num1);


            Console.WriteLine(num1++ == --num2);// notando que o operador na apos a variavel requer menos prioridade, sendo apos, a prioridade é maior
            //então antes da comparação num2 sera decrementado primeiro.
            Console.WriteLine($"{num1}, {num2}");
            
            
           
        }
    }
}
