using ConsoleApp7;

metodos m = new metodos();
try
{
    m.Mostrar(5);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}