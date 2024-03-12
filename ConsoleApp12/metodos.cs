using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class metodos
    {
        public void Mostrar()
        {
            var listaNumero = new List<int>();
            listaNumero.Add(1);
            listaNumero.Add(12);
            listaNumero.Add(14);
            listaNumero.Add(15);

            var sql = from sql1 in listaNumero
                      where sql1%2==0
                      select sql1;
            foreach (var item in sql)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            foreach (var item in listaNumero)
            {
                Console.WriteLine(item);
            }



        }
    }
}
