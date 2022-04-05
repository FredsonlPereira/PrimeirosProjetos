namespace Projeto62Janelas
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            if (tb_Produto.Text == "")
            {
                MessageBox.Show("Digite um Produto");
                tb_Produto.Focus();
                return;
            }
            tb_ListaProd.Text += tb_Produto.Text + ", ";
            tb_Produto.Clear();
            tb_Produto.Focus();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_ListaProd.Clear();
            tb_Produto.Clear();
            tb_Produto.Focus();
        }

        private void tb_ListaProd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_Visualiza_Click(object sender, EventArgs e)
        {
            F_Produtos f_Produtos = new F_Produtos(tb_ListaProd.Text,this);
            //f_Produtos.Show();        // Permite acessar a janela anterior.
            f_Produtos.ShowDialog();    // Não permite acessar a janela anterior.
        }

        private void bt_ValNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PaiCheckBox f_CheckBox = new F_PaiCheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            F_ComboBox f_comboBox = new F_ComboBox();
            f_comboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListaDeProdutos f_ListView = new F_ListaDeProdutos();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();   
        }

        private void MenuAtualizacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_Fechar")
                this.Close();
            else if(e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show ("Programação C#");
            }

        }

        private void fNumericUpdDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpdDown f_NumericUpdDown = new F_NumericUpdDown();
            f_NumericUpdDown.ShowDialog ();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void radiobuttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Radiobutton f_Radiobutton = new F_Radiobutton();
            f_Radiobutton.ShowDialog();
        }
    }
}