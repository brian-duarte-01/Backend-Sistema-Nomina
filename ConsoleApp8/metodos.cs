using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class metodos
    {
        public int[] arrayNumero = new int[5] { 44, 55, 77, 80, 84 };
        int contador = 1;
        int resultado = 0;


        public void Mostrar()
        {
            

            foreach (var item in arrayNumero)
            {
                if (item%2==0)
                {
                    Console.WriteLine(item+" "+contador);
                    resultado = contador;
                    contador++;
                }
            }
           
           

            Console.WriteLine("--------------------------"+resultado);

            foreach (var item in arrayNumero)
            {
                Console.WriteLine(item);
            }
        }
    }
}
