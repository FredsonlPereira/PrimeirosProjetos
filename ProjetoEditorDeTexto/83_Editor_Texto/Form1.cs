using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _83_Editor_Texto
{
    public partial class Form1 : Form
    {
        
        StreamReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void bt_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void bt_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Criação do arquivo.
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    // Criação do escrevedor.
                    StreamWriter flp_StreamWriter = new StreamWriter(arquivo);
                    // zerando o bufer.
                    flp_StreamWriter.Flush();
                    // Ponto de partida do escrevedor.
                    flp_StreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    // Conteúdo do que o escrevedor fai escrever.
                    flp_StreamWriter.Write(this.richTextBox1.Text);
                    flp_StreamWriter.Flush();
                    // Obrigatório o fechamento do StreamWriter.
                    flp_StreamWriter.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Projetos C#\Editor_de_Texto\";
            openFileDialog1.Filter = "(*.FLP)|*.FLP";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader flp_streamReader = new StreamReader(arquivo);
                    flp_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = flp_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = flp_streamReader.ReadLine();
                    }
                    flp_streamReader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro na leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }
    }
}