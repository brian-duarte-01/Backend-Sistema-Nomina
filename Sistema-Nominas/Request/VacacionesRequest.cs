namespace Sistema_Nominas.Request
{
    public class VacacionesRequest
    {
        public string empleado {  get; set; }
        public int meses {  get; set; }
        public decimal sueldo { get; set; }
        public string tipo_pago { get; set; }
        public string estado { get; set; }
    }
}
