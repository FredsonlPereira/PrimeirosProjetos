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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Produtos.Text = cb_Produtos.Text;
        }

        private void bt_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Produtos.Text);  
        }

        private void bt_LimparProdutos_Click(object sender, EventArgs e)
        {
            cb_Produtos.Items.Clear();
        }

        private void bt_ResetarProdutos_Click(object sender, EventArgs e)
        {
            cb_Produtos.Items.Add("Auto Falantes");
            cb_Produtos.Items.Add("Baterias");
            cb_Produtos.Items.Add("Cornetas");
            cb_Produtos.Items.Add("Modulos");
        }

        private void bt_NovoProduto_Click(object sender, EventArgs e)
        {
            if(tb_Produtos.Text != "")
            {
                if(cb_Produtos.FindString(tb_Produtos.Text) <0)
                cb_Produtos.Items.Add(tb_Produtos.Text);
            }
        }

        private void F_ComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
