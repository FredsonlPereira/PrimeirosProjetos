namespace _83_Editor_Texto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_Novo = new System.Windows.Forms.ToolStripButton();
            this.bt_Abrir = new System.Windows.Forms.ToolStripButton();
            this.bt_Salvar = new System.Windows.Forms.ToolStripButton();
            this.bt_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.bt_Copiar = new System.Windows.Forms.ToolStripButton();
            this.bt_Colar = new System.Windows.Forms.ToolStripButton();
            this.bt_Desfazer = new System.Windows.Forms.ToolStripButton();
            this.bt_Refazer = new System.Windows.Forms.ToolStripButton();
            this.bt_Negrito = new System.Windows.Forms.ToolStripButton();
            this.bt_Italico = new System.Windows.Forms.ToolStripButton();
            this.bt_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.bt_Esquerda = new System.Windows.Forms.ToolStripButton();
            this.bt_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.bt_Direita = new System.Windows.Forms.ToolStripButton();
            this.bt_Justificar = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.italicoToolStripMenuItem.Text = "Italico";
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centralizarToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificarToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            // 
            // justificarToolStripMenuItem
            // 
            this.justificarToolStripMenuItem.Name = "justificarToolStripMenuItem";
            this.justificarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.justificarToolStripMenuItem.Text = "Justificar";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_Novo,
            this.bt_Abrir,
            this.bt_Salvar,
            this.bt_Imprimir,
            this.bt_Copiar,
            this.bt_Colar,
            this.bt_Desfazer,
            this.bt_Refazer,
            this.bt_Negrito,
            this.bt_Italico,
            this.bt_Sublinhado,
            this.bt_Esquerda,
            this.bt_Centralizar,
            this.bt_Direita,
            this.bt_Justificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(768, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_Novo
            // 
            this.bt_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Novo.Image = ((System.Drawing.Image)(resources.GetObject("bt_Novo.Image")));
            this.bt_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(23, 22);
            this.bt_Novo.Text = "Novo";
            this.bt_Novo.Click += new System.EventHandler(this.bt_Novo_Click);
            // 
            // bt_Abrir
            // 
            this.bt_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Abrir.Image")));
            this.bt_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Abrir.Name = "bt_Abrir";
            this.bt_Abrir.Size = new System.Drawing.Size(23, 22);
            this.bt_Abrir.Text = "Abrir";
            this.bt_Abrir.Click += new System.EventHandler(this.bt_Abrir_Click);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Salvar.Image")));
            this.bt_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(23, 22);
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("bt_Imprimir.Image")));
            this.bt_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(23, 22);
            this.bt_Imprimir.Text = "Imprimir";
            // 
            // bt_Copiar
            // 
            this.bt_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Copiar.Image")));
            this.bt_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Copiar.Name = "bt_Copiar";
            this.bt_Copiar.Size = new System.Drawing.Size(23, 22);
            this.bt_Copiar.Text = "Copiar";
            // 
            // bt_Colar
            // 
            this.bt_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Colar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Colar.Image")));
            this.bt_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Colar.Name = "bt_Colar";
            this.bt_Colar.Size = new System.Drawing.Size(23, 22);
            this.bt_Colar.Text = "Colar";
            // 
            // bt_Desfazer
            // 
            this.bt_Desfazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Desfazer.Image = ((System.Drawing.Image)(resources.GetObject("bt_Desfazer.Image")));
            this.bt_Desfazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Desfazer.Name = "bt_Desfazer";
            this.bt_Desfazer.Size = new System.Drawing.Size(23, 22);
            this.bt_Desfazer.Text = "Desfazer";
            // 
            // bt_Refazer
            // 
            this.bt_Refazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Refazer.Image = ((System.Drawing.Image)(resources.GetObject("bt_Refazer.Image")));
            this.bt_Refazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Refazer.Name = "bt_Refazer";
            this.bt_Refazer.Size = new System.Drawing.Size(23, 22);
            this.bt_Refazer.Text = "Refazer";
            // 
            // bt_Negrito
            // 
            this.bt_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Negrito.Image = ((System.Drawing.Image)(resources.GetObject("bt_Negrito.Image")));
            this.bt_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Negrito.Name = "bt_Negrito";
            this.bt_Negrito.Size = new System.Drawing.Size(23, 22);
            this.bt_Negrito.Text = "Negrito";
            // 
            // bt_Italico
            // 
            this.bt_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Italico.Image = ((System.Drawing.Image)(resources.GetObject("bt_Italico.Image")));
            this.bt_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Italico.Name = "bt_Italico";
            this.bt_Italico.Size = new System.Drawing.Size(23, 22);
            this.bt_Italico.Text = "Italico";
            // 
            // bt_Sublinhado
            // 
            this.bt_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sublinhado.Image")));
            this.bt_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Sublinhado.Name = "bt_Sublinhado";
            this.bt_Sublinhado.Size = new System.Drawing.Size(23, 22);
            this.bt_Sublinhado.Text = "Sublinhado";
            // 
            // bt_Esquerda
            // 
            this.bt_Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Esquerda.Image = ((System.Drawing.Image)(resources.GetObject("bt_Esquerda.Image")));
            this.bt_Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Esquerda.Name = "bt_Esquerda";
            this.bt_Esquerda.Size = new System.Drawing.Size(23, 22);
            this.bt_Esquerda.Text = "Esquerda";
            // 
            // bt_Centralizar
            // 
            this.bt_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Centralizar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Centralizar.Image")));
            this.bt_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Centralizar.Name = "bt_Centralizar";
            this.bt_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.bt_Centralizar.Text = "Centralizar";
            // 
            // bt_Direita
            // 
            this.bt_Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Direita.Image = ((System.Drawing.Image)(resources.GetObject("bt_Direita.Image")));
            this.bt_Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Direita.Name = "bt_Direita";
            this.bt_Direita.Size = new System.Drawing.Size(23, 22);
            this.bt_Direita.Text = "Direita";
            // 
            // bt_Justificar
            // 
            this.bt_Justificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_Justificar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Justificar.Image")));
            this.bt_Justificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_Justificar.Name = "bt_Justificar";
            this.bt_Justificar.Size = new System.Drawing.Size(23, 22);
            this.bt_Justificar.Text = "Justificar";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(768, 309);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "flp";
            this.saveFileDialog1.Filter = "(*.FLP)|*.FLP";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 362);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem italicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripMenuItem justificarToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton bt_Novo;
        private ToolStripButton bt_Abrir;
        private ToolStripButton bt_Salvar;
        private ToolStripButton bt_Imprimir;
        private ToolStripButton bt_Copiar;
        private ToolStripButton bt_Colar;
        private ToolStripButton bt_Desfazer;
        private ToolStripButton bt_Refazer;
        private ToolStripButton bt_Negrito;
        private ToolStripButton bt_Italico;
        private ToolStripButton bt_Sublinhado;
        private ToolStripButton bt_Esquerda;
        private ToolStripButton bt_Centralizar;
        private ToolStripButton bt_Direita;
        private ToolStripButton bt_Justificar;
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}