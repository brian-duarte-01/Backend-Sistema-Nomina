namespace Sistema_Nominas.Request
{
    public class EmpleadoRequest
    {
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string nit { get; set; }
        public string calle { get; set; }
        public string avenida { get; set; }
        public string zona { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string empresa { get; set; }
    }
}
