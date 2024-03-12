namespace WebApplication2.Config
{
    public class Conexion
    {
        private static Conexion instance = null;
        public string cadenaCorrecta {  get; set; }

        protected Conexion()
        {
            this.cadenaCorrecta = "server=.; database=CrudNotas; integrated security=true; TrustServerCertificate=true;";
        }

        public static Conexion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Conexion();
                }
                return instance;
            }
        }
    }
}
