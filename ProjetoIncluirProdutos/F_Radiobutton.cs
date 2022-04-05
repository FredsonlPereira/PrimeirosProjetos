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
    public partial class F_Radiobutton : Form
    {
        public F_Radiobutton()
        {
            InitializeComponent();
        }

        private void bt_Selecao01_Click(object sender, EventArgs e)
        {
            ////seleção 01 Mais difícil
            //string txt;

            //txt = gb_A.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton =>RadioButton.Checked).Text;

            //textBox1.Text = txt;
            //MessageBox.Show(txt);

            string txt = "";
            foreach (RadioButton rb in gb_A.Controls)
            {
                if (rb.Checked)
                {
                    txt = rb.Text;
                }
            }
            textBox1.Text = txt;
            MessageBox.Show(txt);
        }

        private void bt_Selecao02_Click(object sender, EventArgs e)
        {
            //seleção 02 Mais fácil
            //string txt = "";
            //foreach (RadioButton rb in gb_A.Controls)
            //{
            //    if (rb.Checked)
            //    {
            //        txt = rb.Text;
            //    }
            //}
            //textBox1.Text = txt;
            //MessageBox.Show(txt);
        }



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void F_Radiobutton_Load(object sender, EventArgs e)
        {

        }
    }
}
