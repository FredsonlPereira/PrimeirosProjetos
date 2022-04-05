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
    public partial class F_ListaDeProdutos : Form
    {
        public F_ListaDeProdutos()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_Id.Clear();
            tb_Produto.Clear();
            tb_Qtde.Clear();    
            tb_Preco.Clear();
            tb_Id.Focus(); 
        }
        private void obter()
        {
            tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_Qtde.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            if(tb_Id.Text == "")
            {
                MessageBox.Show("Id não pode ser vazio");
                tb_Id.Focus();
                return;
            }
            if (tb_Produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio");
                tb_Produto.Focus();
                return;
            }
            if (tb_Qtde.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio");
                tb_Qtde.Focus();
                return;
            }
            if (tb_Preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio");
                tb_Preco.Focus();
                return;
            }

            string[] prod = new string[4];
            prod[0] = tb_Id.Text;
            prod[1] = tb_Produto.Text;
            prod[2] = tb_Qtde.Text;
            prod[3] = tb_Preco.Text;

            ListViewItem l = new ListViewItem(prod);
            lv_Produtos.Items.Add(l);
            limpar();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
        }

        private void bt_Pesquisar_Click(object sender, EventArgs e)
        {
            obter();
        }

        private void lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Produtos.SelectedItems.Count > 0)
            {
                obter();
            }
        }

        private void F_ListaDeProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
