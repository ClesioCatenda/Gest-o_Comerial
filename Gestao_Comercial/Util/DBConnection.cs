using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Util
{
    public class DBConnection
    {
        private Connection connection;
        private SqlConnection sqlconnection = null;
        private SqlCommand sqlCommand;
        private SqlParameterCollection sqlParameterCollection;
       
        
        public DBConnection()
        {
            this.connection = new Connection();
            this.sqlconnection = new SqlConnection(connection.getConnectionString());
            this.sqlCommand = null;
            this.sqlParameterCollection = new SqlCommand().Parameters;

        }

        private void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        /*---------------- adicionar Parametros no SqlParameterColection*/
        public void AdicionarParametros(string NomeParametro, object ValoParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(NomeParametro, ValoParametro));
        }
     

        //---------------------- Instrução para Inserir
        public void Manipulacao(CommandType commandType, string query)
        {

            sqlconnection.Close();
            try
            {
                sqlconnection.Open();
                SqlCommand sqlCommand = sqlconnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 7200; //  tempo Máximo para executar a consulta e retornar algo

                foreach (SqlParameter sqlParametro in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParametro.ParameterName, sqlParametro.Value));
                }
                 sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ecepcao)
            {
                throw new Exception(ecepcao.Message);
            }
            finally
            {
                sqlconnection.Close();
                LimparParametros();
            }
        }


        //---------------------- Instrução para Selectionar
        public SqlDataAdapter Consulta(CommandType commandtype, string consulta)
        {
            sqlconnection.Close();
            try
            {
                sqlconnection.Open();
                sqlCommand = sqlconnection.CreateCommand();
                sqlCommand.CommandText = consulta;
                sqlCommand.CommandType = commandtype;
                sqlCommand.CommandTimeout = 7200;
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sqlCommand);

                return SqlDataAdapter;
            }
            catch (Exception ecepcao)
            {
                throw new Exception(ecepcao.Message);
            }
            finally
            {
                sqlconnection.Close();
                LimparParametros();
            }
        }

        public SqlDataReader Consultar(CommandType commandType, String query)
        {
            sqlconnection.Close();
            try
            {
                sqlconnection.Open();
                sqlCommand = sqlconnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = query;
                sqlCommand.CommandTimeout = 7200;

                foreach (SqlParameter sqlParametro in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParametro.ParameterName, sqlParametro.Value));
                }
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlDataReader;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //sqlconnection.Close();
                LimparParametros();
            }
        }

    }
}
