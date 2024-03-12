using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class metodos
    {
        public int numero {  get; set; }
        int resultado { get; set; }
        public void mostrar()
        {
            for (int i=0; i<=10;i++)
            {
                resultado = this.numero * i;
                Console.WriteLine(this.numero+" X "+i+" = "+resultado);
            }
        }
    }
}
