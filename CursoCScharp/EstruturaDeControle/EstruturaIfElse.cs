using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
       public static void Executar()
        {
            double nota = 7.0;

            if(nota >= 7.0){
                Console.WriteLine("Foi aprovado!!");
                Console.WriteLine("Não Fez mais que sua obrigação... ");

            }else{
                Console.WriteLine("Recuperação");
            }
        } 
    }
}
