using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produto
    {
       
        public int  Id { get; set; }

        public String Codigo { get; set; }

        public String Nome { get; set; }

        public decimal Preco_Custo { get; set; }

        public decimal Preco_Venda { get; set; }

        public int Quant_Estoque { get; set; }

        public int Id_Fornecedor { get; set; }

        public int Id_Local_Armazenamento{ get; set; }
        public Boolean Ativo { get; set; }
        public String Imagem { get; set; }





        public Produto(int Id, String Codigo,String Nome, decimal Preco_cuso, decimal Preco_venda,int quant_Stock,int Id_fornecedor,int Id_Armazem,Boolean Ativo, String Imagem) {

            this.Id = Id;
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco_Custo = Preco_cuso;
            this.Preco_Venda = Preco_venda;
            this.Quant_Estoque = quant_Stock;
            this.Id_Fornecedor = Id_fornecedor;
            this.Id_Local_Armazenamento = Id_Armazem;
            this.Ativo = Ativo;
            this.Imagem = Imagem;

        }

        public Produto()
        {
        
        }

        public Produto(String Codigo, String Nome, decimal Preco_cuso, decimal Preco_venda, int quant_Stock, int Id_fornecedor, int Id_Armazem, Boolean Ativo, String Imagem)
        {

       
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco_Custo = Preco_cuso;
            this.Preco_Venda = Preco_venda;
            this.Quant_Estoque = quant_Stock;
            this.Id_Fornecedor = Id_fornecedor;
            this.Id_Local_Armazenamento = Id_Armazem;
            this.Ativo = Ativo;
            this.Imagem = Imagem;

        }
    }
}
