using System;

namespace Pruebas
{
    class Program
    {
        public static int i = 0, j = 1, altura = 0, peso = 0, cantidadPromedio = 1;
        static void Main(string[] args)
        {
            ArregloArbol arregloArbol = new ArregloArbol();

            Console.WriteLine("Escriba los numeros del arbol: ");
            bool fin = false;

            while (!fin)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                arregloArbol.Insertar(numero);


                Console.WriteLine("desea agregar mas elementos al arbol?: Escriba 1 para continuar, dos para terminar. ");
                int validacion = Convert.ToInt32(Console.ReadLine());
                switch (validacion)
                {
                    case 1:
                        Console.WriteLine("escriba el siguiente numero");
                        fin = false;
                        break;
                    case 2:
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("desea agregar mas elementos al arbol?: Escriba 1 para continuar, dos para terminar. ");
                        break;
                }
            }
            Console.Clear();

            Altura(arregloArbol.raiz);
            peso = arregloArbol.raiz.valor;
            Peso(arregloArbol.raiz);

            Console.WriteLine("El peso del arbol es: " + peso);
            Console.WriteLine("El peso del arbol es: " + arregloArbol.PesoPromedio(peso, cantidadPromedio));
            Console.WriteLine("La altura del arbol es: " + altura);

        }

        public static void Altura(Nodo raiz)
        {
            if (raiz != null)
            {
                i++;
                if (i == j)
                {
                    j++;
                    altura = j - 1;
                    altura = altura - 1;
                }

                Altura(raiz.nodoIzq);
                Altura(raiz.nodoDer);

                i--;
            }
        }
        public static void Peso(Nodo raiz)
        {
            if (raiz.nodoIzq != null)
            {
                cantidadPromedio += 1;

                peso = peso + raiz.nodoIzq.valor;
                Peso(raiz.nodoIzq);
            }
            if (raiz.nodoDer != null)
            {
                cantidadPromedio += 1;

                peso = peso + raiz.nodoDer.valor;
                Peso(raiz.nodoDer);
            }
        }
    }
}

