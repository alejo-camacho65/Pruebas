using System;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer numero: ");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero: ");
            int numeroDos = Convert.ToInt32(Console.ReadLine());

            NumeroEnteros numeroEnteros = new NumeroEnteros();
            var resultado = numeroEnteros.Division(numeroUno, numeroDos);
            Console.WriteLine(resultado);
        }
    }
}

