using ConsoleApp10;

metodos m = new metodos();
contadorDelegate contador = m.contadorAsync;

await contador();
Console.WriteLine("Ha terminado el proceso");