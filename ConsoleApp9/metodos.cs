using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class metodos
    {
        public void Mostrar()
        {
            var listaPalabra = new List<string>();
            listaPalabra.Add("Brian");
            listaPalabra.Add("Jose");
            listaPalabra.Add("Luis");

            foreach (var item in listaPalabra)
            {
                if (item.Contains("a"))
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("-----------------------");

            foreach (var item in listaPalabra)
            {
                Console.WriteLine(item);
            }
        }
    }
}
