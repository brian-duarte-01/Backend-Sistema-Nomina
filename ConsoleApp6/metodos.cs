using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class metodos
    {
        public int numero {  get; set; }

        public void Mostrar()
        {
            var listaNota = new List<Notas>();

            for (int i=1; i<=this.numero;i++)
            {
                var n = new Notas();
                Console.WriteLine("Nombre");
                n.nombre = Console.ReadLine();
                Console.WriteLine("Nota");
                n.nota = Convert.ToDouble(Console.ReadLine());
                listaNota.Add(n);
            }

            foreach (var item in listaNota)
            {
                Console.WriteLine("Nombre: "+item.nombre+", Nota: "+item.nota);
            }
        }
    }
}
