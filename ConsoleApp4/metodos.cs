using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class metodos
    {
        public int numero {  get; set; }
        public void Mostrar()
        {
            do
            {
                Console.WriteLine("Ingrese numero");
                this.numero = Convert.ToInt32(Console.ReadLine());
            }
            while (this.numero!=10);
        }
    }
}
