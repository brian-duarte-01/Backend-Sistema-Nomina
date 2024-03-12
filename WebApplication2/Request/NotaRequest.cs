namespace WebApplication2.Request
{
    public class NotaRequest
    {
        public string nombre {  get; set; }
        public decimal nota1 { get; set; }
        public decimal nota2 { get; set;}
        public DateTime fecha { get; set; } = DateTime.Now;
    }
}
