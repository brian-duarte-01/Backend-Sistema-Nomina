using ConsoleApp11;

metodos m = new metodos();
Func<string, string> ocadena = m.ObtenerMayusculayLongitud;
Console.WriteLine(ocadena("hola"));

Action<int, int> ouma = m.suma;
ouma(5,5);