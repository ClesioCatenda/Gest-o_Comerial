using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Util;
using Model;

namespace Controller
{
    public class ProdutoController
    {

        private DBConnection dBConnection;
        public ProdutoController()
        {
            this.dBConnection = new DBConnection();
        }

        public void novoProduto(Produto produto)
        {
            try
            {
                dBConnection.AdicionarParametros("@Codigo", produto.Codigo);
                dBConnection.AdicionarParametros("@Nome", produto.Nome);
                dBConnection.AdicionarParametros("@Preco_Custo", produto.Preco_Custo);
                dBConnection.AdicionarParametros("@Preco_Venda", produto.Preco_Venda);
                dBConnection.AdicionarParametros("@Quant_Estoque", produto.Quant_Estoque);
                dBConnection.AdicionarParametros("@Id_Fornecedor", produto.Id_Fornecedor);
                dBConnection.AdicionarParametros("@Id_Local_Armazenamento", produto.Id_Local_Armazenamento);
                dBConnection.AdicionarParametros("@Ativo", produto.Ativo);
                dBConnection.AdicionarParametros("@Imagem", produto.Imagem);
                dBConnection.Manipulacao(CommandType.StoredProcedure, "add_produto");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public void editarProduto(Produto produto)
        {
            try
            {

                dBConnection.AdicionarParametros("@Id", produto.Id);
                dBConnection.AdicionarParametros("@Codigo", produto.Codigo);
                dBConnection.AdicionarParametros("@Nome", produto.Nome);
                dBConnection.AdicionarParametros("@Preco_Custo", produto.Preco_Custo);
                dBConnection.AdicionarParametros("@Preco_Venda", produto.Preco_Venda);
                dBConnection.AdicionarParametros("@Quant_Estoque", produto.Quant_Estoque);
                dBConnection.AdicionarParametros("@Id_Fornecedor", produto.Id_Fornecedor);
                dBConnection.AdicionarParametros("@Id_Local_Armazenamento", produto.Id_Local_Armazenamento);
                dBConnection.AdicionarParametros("@Ativo", produto.Ativo);
                dBConnection.AdicionarParametros("@Imagem", produto.Imagem);
                dBConnection.Manipulacao(CommandType.StoredProcedure, "");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void eliminarLicao(int codigo)
        {
            try
            {
                dBConnection.AdicionarParametros("@codigo", codigo);
                dBConnection.Manipulacao(CommandType.Text, " delete from Produdo where I");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public DataTable lista_de_ProdutosDataTable()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter mySqlDataAdapter = dBConnection.Consulta(CommandType.Text, "select * from Produto");
                mySqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }
        public List<Produto> detalhesLista()
        {
            try
            {
                List<Produto> lista = new List<Produto>();
                SqlDataReader mySqlDatareader = dBConnection.Consultar(CommandType.Text, "select * from Produto");
                while (mySqlDatareader.Read())
                {
                    lista.Add(new Produto(
                    mySqlDatareader["Codigo"].ToString(),
                    mySqlDatareader["@Nome"].ToString(),
                    Convert.ToDecimal(mySqlDatareader["@Preco_Custo"]),
                    Convert.ToDecimal(mySqlDatareader["@Preco_Venda"]),
                    Convert.ToInt32(mySqlDatareader["@Quant_Estoque"]),
                    Convert.ToInt32(mySqlDatareader["@Id_Fornecedor"]),
                    Convert.ToInt32(mySqlDatareader["@Id_Local_Armazenamento"]),
                    Convert.ToBoolean(mySqlDatareader["@Ativo"]),
                    mySqlDatareader["@Imagem"].ToString()));
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
