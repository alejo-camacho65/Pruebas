using System;

namespace Pruebas
{
    public class NumeroBase
    {
        public string ObtenerCambioBase(int numeroUno, int numeroBase)
        {
            int division = numeroUno / numeroBase;
            int residuo = numeroUno % numeroBase;
            string resultado = Convert.ToString(residuo);

            while (division != 1)
            {
                residuo = division % numeroBase;
                division = division / numeroBase;

                resultado = residuo + resultado;
            }
            resultado = division + "" + resultado;
            return resultado;
        }
    }
}
