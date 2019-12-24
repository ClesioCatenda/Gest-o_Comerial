using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Util
{
    public class Connection
    {
        private string Server = "";
        private String Usuario = "";
        private String Senha = "";
        private String Banco = "";


        private String Connection_sting;
        public Connection()
        {
            Connection_sting = string.Format("server={0};database={1};user={2};password={3}", Server, Banco, Usuario, Senha);
            try
            {
                SqlConnection cx = new SqlConnection(Connection_sting);
                cx.Open();
              
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public String getConnectionString()
        {
            return this.Connection_sting;
                       
        }
    }
}
