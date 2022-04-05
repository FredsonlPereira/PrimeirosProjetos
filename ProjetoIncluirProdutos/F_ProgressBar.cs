using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto62Janelas
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void bt_DefValor_Click(object sender, EventArgs e)
        {
            if((int.Parse(tb_Inicio.Text) >= progressBar1.Minimum) & (int.Parse(tb_Inicio.Text) <= progressBar1.Maximum))
                    progressBar1.Value = int.Parse(tb_Inicio.Text);
        }

        private void bt_VerProgresso_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(tb_Fim.Text);
            for (int i = 0; i <= int.Parse(tb_Fim.Text); i++)
            {
                lb_Contador.Text = i.ToString();
                progressBar1.Value = i;
                //Thread.Sleep(200);
            }
        }
    }
}