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
    public partial class incializacao : Form
    {
        public incializacao()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void contador_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value < 100)
            {
                bunifuCircleProgressbar1.Value = bunifuCircleProgressbar1.Value + 10;
            }
            else
            {
                contador.Stop();
                this.Visible = false;
                tela_login fr = new tela_login();
                fr.ShowDialog();
            }
        }
    }
}
