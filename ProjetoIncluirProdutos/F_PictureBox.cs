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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCurso;
            label2.Text = Properties.Resources.LocalCurso;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Bass_Acessorios;
        }

        private void bt_BS_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Bass_Som;
        }

        private void bt_Placa_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Propaganda;
        }
    }
}
