namespace Sistema_Nomina.Config
{
    public class Conexion: ConexionEntity
    {
        private static Conexion instance = null;
        public string cadenaConexion { get; set; }

        protected Conexion()
        {
            this.cadenaConexion = "Data Source="+dataSource+"; User Id="+Id+"; Password="+Password+";";
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
