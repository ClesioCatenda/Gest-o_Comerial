using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestShop
{
    public partial class tela_principal : Form
    {
        public tela_principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desejas Fechar o Programa","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
              Application.Exit();
            }
           
            
        }
        private void AbrirFormEmPanelPrincipal(object formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonPrincipal.Height;
            panelsinal.Top = buttonPrincipal.Top;
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonProduto.Height;
            panelsinal.Top = buttonProduto.Top;
            AbrirFormEmPanelPrincipal(new tela_produto());
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonVendas.Height;
            panelsinal.Top = buttonVendas.Top;
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonFornecedor.Height;
            panelsinal.Top = buttonFornecedor.Top;
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonStock.Height;
            panelsinal.Top = buttonStock.Top;
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonFuncionario.Height;
            panelsinal.Top = buttonFuncionario.Top;
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonCliente.Height;
            panelsinal.Top = buttonCliente.Top;
        }

        private void buttonCategoria_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonCategoria.Height;
            panelsinal.Top = buttonCategoria.Top;
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonRelatorio.Height;
            panelsinal.Top = buttonRelatorio.Top;
        }

        private void buttonConfiguracao_Click(object sender, EventArgs e)
        {
            panelsinal.Height = buttonConfiguracao.Height;
            panelsinal.Top = buttonConfiguracao.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void Fechar_Tick(object sender, EventArgs e)
        {
      
        }



        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(panelLeft.Width.ToString());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }
    }
}
