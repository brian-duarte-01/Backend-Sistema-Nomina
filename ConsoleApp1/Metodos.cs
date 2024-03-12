using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Metodos
    {
        public int año {  get; set; }

        public void Mostrar()
        {
            if (this.año %4 ==0 && this.año%100!=0 || this.año%400==0)
            {
                Console.WriteLine("Es año bisiesto "+this.año);
            }
            else
            {
                Console.WriteLine("No es año bisiesto "+this.año);
            }
        }
    }
}
