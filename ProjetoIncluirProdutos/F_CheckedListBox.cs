using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Exemplo 01
//namespace Projeto62Janelas
//{
//    public partial class F_CheckedListBox : Form
//    {
//        public F_CheckedListBox()
//        {
//            InitializeComponent();
//        }

//        private void F_CheckedListBox_Load(object sender, EventArgs e)
//        {

//        }

//        private void clb_Produtos_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void tb_NovosProd_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void bt_VisualizaProd_Click(object sender, EventArgs e)
//        {
//            string txt = "";
//            txt = clb_Produtos.Items[0].ToString();               //Visualiza o primeiro item da Lista.
//            //txt = clb_Produtos.CheckedItems[0].ToString();      //Visualiza o primeiro item da Lista selecionada.
//            MessageBox.Show(txt);
//        }
//    }
//}


// Exemplo 02 - Usando Foreach para visualizar Produtos Selecionados.
namespace Projeto62Janelas
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void F_CheckedListBox_Load(object sender, EventArgs e)
        {

        }

        private void clb_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_NovosProd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_VisualizaProd_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string p in clb_Produtos.CheckedItems)
            {
                txt += p + ", ";
            }
            
            MessageBox.Show(txt);
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            clb_Produtos.Items.Clear();
        }

        private void bt_Resetar_Click(object sender, EventArgs e)
        {
            //Teste 01 - Limpa apenas 01 produto "modulos"
            //clb_Produtos.Items.Add("Módulo", true);

            //Teste 02 - Limpa apenas 01 produto "modulos"
            //object modulos="Modulos";
            //clb_Produtos.Items.Add(modulos, true);

            //Teste 03 - Limpar e resetar toda a lista de uma só vez, use o Clear para evitar que adicione a lista mais de uma vez.
            //clb_Produtos.Items.Clear();
            //clb_Produtos.Items.Add("Auto Falantes", false);
            //clb_Produtos.Items.Add("Baterias", false);
            //clb_Produtos.Items.Add("Cornetas", false);
            //clb_Produtos.Items.Add("Modulos", false);

            //Teste 04 - Usando o AddRange, usando a lista pronta.
            clb_Produtos.Items.Clear();
            List<string> prod = new List<string>();
            prod.Add("Auto Falantes");
            prod.Add("Baterias");
            prod.Add("Cornetas");
            prod.Add("Módulos");

            clb_Produtos.Items.AddRange(prod.ToArray());

        }

        private void bt_NovosProdutos_Click(object sender, EventArgs e)
        {
            if (tb_NovosProd.Text != "")
            {
                clb_Produtos.Items.Add(tb_NovosProd.Text);
            }
        }
    }
}