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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void F_MaskedTextBox_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mtq_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtq_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            String msg = mtq_cpf.Text;
            MessageBox.Show(msg);
        }

        private void mtq_Senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}