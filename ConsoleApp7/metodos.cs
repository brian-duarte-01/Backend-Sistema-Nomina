using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class metodos
    {
 

        public void Mostrar(int n)
        {
            if (n<0)
            {
                throw new NotImplementedException("No se aceptan negativos");
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
