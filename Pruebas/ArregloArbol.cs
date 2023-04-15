using System;

namespace Pruebas
{
    class ArregloArbol
    {
        public Nodo raiz;
        public ArregloArbol()
        {
            raiz = null;
        }

        public void Insertar(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.nodoDer = null;
                nuevo.nodoIzq = null;

                Nodo anterior = null, recorrer;
                recorrer = raiz;

                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (valor < recorrer.valor)
                    {
                        recorrer = recorrer.nodoDer;

                    }
                    else
                    {
                        recorrer = recorrer.nodoIzq;

                    }
                }

                if (valor < anterior.valor)
                {
                    anterior.nodoDer = nuevo;
                }
                else
                {
                    anterior.nodoIzq = nuevo;
                }
            }
        }

        public void PreOrden(Nodo raiz)
        {
            if (raiz.nodoIzq != null)
            {
                PreOrden(raiz.nodoIzq);
            }
            if (raiz.nodoDer != null)
            {
                PreOrden(raiz.nodoDer);
            }
        }

        public double PesoPromedio(int peso, int cantidad)
        {
            double resultado = Convert.ToDouble(peso) / Convert.ToDouble(cantidad);
            return resultado;
        }
    }
}

