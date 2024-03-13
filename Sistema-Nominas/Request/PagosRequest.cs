namespace Sistema_Nominas.Request
{
    public class PagosRequest
    {
        public string empleado {  get; set; }
        public decimal salario { get; set; }
        public decimal bonificacion { get; set; }
        public string tipo_pago { get; set; }
        public string estado { get; set; }  
    }
}
