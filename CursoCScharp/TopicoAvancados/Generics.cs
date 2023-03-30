using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCScharp.TopicoAvancados {

    public class Caixa<T> {
        T valorPrivado;
        public T Coisa { get; set; }
        public Caixa(T coisa) {
            Coisa= coisa;
        }
        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }
         public T Getvalor() {
            return valorPrivado;
        }
    }
    internal class Generics {
        public static void Executar() {

        }
    }
}
