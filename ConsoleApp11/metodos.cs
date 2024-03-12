using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class metodos
    {
        public string ObtenerMayusculayLongitud(string cadena)
        {
            return cadena.Length + " " + cadena.ToUpper();
        }

        public void suma(int numero, int numero1)
        {
            int resultados = 0;

            resultados = numero1 + numero;
            Console.WriteLine(resultados);
        }
    }
}
