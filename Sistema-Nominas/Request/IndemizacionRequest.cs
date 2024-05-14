namespace Sistema_Nominas.Request
{
    public class IndemizacionRequest
    {
        public string empleado {  get; set; }
        public int anos { get; set; }
        public int meses { get; set; }
        public decimal salario { get; set; }
        public string tipo_pago { get; set; }
        public string estado { get; set; }
    }
}
