using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public delegate Task contadorDelegate();
    public class metodos
    {
        public int contador = 0;
        public async Task contadorAsync()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Loading.......");
            Thread.Sleep(2000);
            Console.WriteLine("Loading.......");
            Thread.Sleep(2000);
            Console.WriteLine("Loading.......");
            Thread.Sleep(2000);
            Console.WriteLine("ingrese duracion");
            contador = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            Console.WriteLine("Enviando.......");
            Thread.Sleep(2000);
            Console.WriteLine("Enviando.......");
            Thread.Sleep(2000);
            Console.WriteLine("Enviando.......");
            Thread.Sleep(2000);
            var task = new Task(() =>
            {
                for (int i=contador;i>=0;i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            });

            task.Start();

            await task;
        }
    }
}
