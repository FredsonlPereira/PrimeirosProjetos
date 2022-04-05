using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Exemplo 01 - Usando o IF.
//namespace Projeto62Janelas
//{
//    public partial class F_CheckBox : Form
//    {
//        public F_CheckBox()
//        {
//            InitializeComponent();
//        }

//        private void bt_TranspMarc_Click(object sender, EventArgs e)
//        {
//            string txt = "";
//            if (cb_AutoFalante.Checked)
//            {
//                txt += cb_AutoFalante.Text + ", ";
//            }
//            if (cb_Baterias.Checked)
//            {
//                txt += cb_Baterias.Text + ", ";
//            }
//            if (cb_Cornetas.Checked)
//            {
//                txt += cb_Cornetas.Text + ", ";
//            }
//            if (cb_Modulos.Checked)
//            {
//                txt += cb_Modulos.Text + ", ";
//            }
//            MessageBox.Show(txt);
//        }

//        private void F_CheckBox_Load(object sender, EventArgs e)
//        {

//        }

//        private void cb_FonteEnergia_CheckedChanged(object sender, EventArgs e)
//        {
//            if(cb_FonteEnergia.Checked)
//            {
//                MessageBox.Show("Fonte de energia marcada");
//            }
//        }
//    }
//}

// Exemplo 02 - Usando o FOREACH (melhor opção na minha opinião, diminui as linhas de código).
namespace Projeto62Janelas
{
    public partial class F_PaiCheckBox : Form
    {
        List <CheckBox> prod = new List<CheckBox>();
        public F_PaiCheckBox()
        {
            InitializeComponent();
            prod.Add(cb_AutoFalante);
            prod.Add(cb_Baterias);
            prod.Add(cb_Cornetas);
            prod.Add(cb_Modulos);
        }

        private void bt_TranspMarc_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach (CheckBox P in prod)
                if (P.Checked)
                {
                    txt += P.Text + ", ";
                }
            MessageBox.Show(txt);
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_FonteEnergia_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_FonteEnergia.Checked)
            {
                MessageBox.Show("Fonte de energia marcada");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }
    }
}
