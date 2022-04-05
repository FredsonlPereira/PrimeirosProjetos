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
    public partial class F_ListBox : Form
    {
        List<string> Produtos = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            Produtos.Add("Baterias");
            Produtos.Add("Cornetas");
            Produtos.Add("Módulos");

            lb_Produtos.DataSource = Produtos;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            if (tb_Produto.Text == "")
            {
                MessageBox.Show("Digite um Produto");
                tb_Produto.Focus();
            }
            else 
            {
                Produtos.Add(tb_Produto.Text);
                tb_Produto.Clear();
                lb_Produtos.DataSource = null;
                lb_Produtos.DataSource = Produtos;
            }
        }

        private void bt_Remover_Click(object sender, EventArgs e)
        {
            Produtos.RemoveAt(lb_Produtos.SelectedIndex);
            lb_Produtos.DataSource = null;
            lb_Produtos.DataSource = Produtos;
        }

        private void bt_Obter_Click(object sender, EventArgs e)
        {
            tb_Produto.Text = Produtos[lb_Produtos.SelectedIndex];
        }

        private void tb_Produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            Produtos.Clear();
            lb_Produtos.DataSource = null;
            lb_Produtos.DataSource = Produtos;
        }
    }
}
