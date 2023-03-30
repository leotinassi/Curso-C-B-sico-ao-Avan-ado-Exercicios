﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamento = true;

            var resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";// ternario por ter 3 etapas. 
            
            Console.WriteLine(resultado);
        }
    }
}
