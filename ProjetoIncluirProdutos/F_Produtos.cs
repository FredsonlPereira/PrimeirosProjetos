using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto62Janelas
{
    public partial class F_Produtos : Form
    {
        F_Principal fp;
        public F_Produtos(string P, F_Principal f) //Lançada a string v 
        {
            InitializeComponent();
            tb_ListaProdutos.Text = P;
            fp = f;
            f.num = 10;
        }

        private void F_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void tb_ListaProdutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_ListaProd.Text = tb_ListaProdutos.Text;
        }
    }
}
