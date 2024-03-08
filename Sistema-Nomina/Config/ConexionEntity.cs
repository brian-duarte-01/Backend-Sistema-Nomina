namespace Sistema_Nomina.Config
{
    public class ConexionEntity
    {
        protected string dataSource {  get; set; }
        protected string Id { get; set; }
        protected string Password { get; set; }

        protected ConexionEntity() 
        {
            this.dataSource = "localhost:1521/orcl";
            this.Id = "NOMINA";
            this.Password = "123";
        }
    }
}
