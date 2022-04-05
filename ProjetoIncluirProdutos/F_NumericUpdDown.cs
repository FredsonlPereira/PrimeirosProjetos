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
    public partial class F_NumericUpdDown : Form
    {
        public F_NumericUpdDown()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_DefinirValor_Click(object sender, EventArgs e)
        {
            if  ((Decimal.Parse(tb_Valor.Text) >= numericUpDown1.Minimum) & 
                (Decimal.Parse(tb_Valor.Text) <= numericUpDown1.Maximum))

            numericUpDown1.Value = Decimal.Parse(tb_Valor.Text);
        }

        private void F_NumericUpdDown_Load(object sender, EventArgs e)
        {

        }
    }
}
