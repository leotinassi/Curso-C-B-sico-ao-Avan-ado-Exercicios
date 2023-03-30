using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper().Insert(3, " World!")
                .Replace("world!", "Mundo!");
            Console.WriteLine(saudacao);

            string valorImporte = null;
            Console.WriteLine(valorImporte?.Length);//o uso do interrogação no c#  é chamado de navegação seguro
            //faz com que o metodo ou funcionalidade seja utilizado apenas se o valor na variavel for compativel com o que o metodo pede.

        }
    }
}
