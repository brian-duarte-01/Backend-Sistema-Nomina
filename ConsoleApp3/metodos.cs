using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class metodos
    {
        public int numero {  get; set; }

        public void Mostra()
        {
            while (numero != 10)
            {
                Console.WriteLine("Ingrese el numero adivinar");
                numero = Convert.ToInt32(Console.ReadLine());

                if (this.numero == 10)
                {
                    Console.WriteLine("Adivinaste el numero y si es: "+this.numero);
                }
                else if(this.numero<10)
                {
                    Console.WriteLine("El numero que ingresaste es menor al que estas adivinando");
                }
                else
                {
                    Console.WriteLine("El numero que ingresaste es mayor al que estas adivinando");
                }
            }
        }
    }
}
