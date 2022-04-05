namespace Projeto61PrimJanExec
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_texto_Click(object sender, EventArgs e)
        {
            //Exemplo 01
            //string txt
            //txt=tb_texto.Text;
            //lb_texto.Text=txt;

            //Exemplo 02 (MAIS PRÁTICO, MENOS LINHAS)
            lb_texto.Text = tb_texto.Text;
        }
    }
}