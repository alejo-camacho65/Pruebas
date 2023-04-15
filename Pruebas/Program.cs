using System;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba elnumero: ");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la base: ");
            int numeroBase = Convert.ToInt32(Console.ReadLine());

            NumeroBase numeroBases = new NumeroBase();
            string resultado = numeroBases.ObtenerCambioBase(numeroUno, numeroBase);
            Console.WriteLine("El numero " + numeroUno + " B10 = " + resultado + " B" + numeroBase);
        }        
    }
}