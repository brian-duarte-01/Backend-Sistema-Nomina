using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class metodos
    {
        public string unidad { get; set; }
        public void Mostrar()
        {
            switch (unidad)
            {
                case "METROS":
                    Console.WriteLine("MTS");
                    break;
                case "KILOGRAMOS":
                    Console.WriteLine("KG");
                    break;
                case "LITROS":
                    Console.WriteLine("LTS");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;

            }
        }
    }
}
