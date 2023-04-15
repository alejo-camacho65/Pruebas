using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Nodo
    {
        public Nodo nodoIzq;
        public Nodo nodoDer;
        public int valor;

        public Nodo() {
            nodoIzq = null;
            nodoDer = null;
            valor = 0;
        }
    }
}
