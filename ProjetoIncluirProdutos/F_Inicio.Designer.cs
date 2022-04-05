namespace Projeto62Janelas
{
    partial class F_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.tb_ListaProd = new System.Windows.Forms.TextBox();
            this.bt_Incluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Visualiza = new System.Windows.Forms.Button();
            this.bt_ValNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fNumericUpdDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuAtualizacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.radiobuttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuAtualizacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Produto
            // 
            this.tb_Produto.Location = new System.Drawing.Point(12, 49);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(148, 23);
            this.tb_Produto.TabIndex = 1;
            // 
            // tb_ListaProd
            // 
            this.tb_ListaProd.Location = new System.Drawing.Point(12, 79);
            this.tb_ListaProd.Multiline = true;
            this.tb_ListaProd.Name = "tb_ListaProd";
            this.tb_ListaProd.ReadOnly = true;
            this.tb_ListaProd.Size = new System.Drawing.Size(260, 214);
            this.tb_ListaProd.TabIndex = 2;
            this.tb_ListaProd.TextChanged += new System.EventHandler(this.tb_ListaProd_TextChanged);
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Location = new System.Drawing.Point(186, 49);
            this.bt_Incluir.Name = "bt_Incluir";
            this.bt_Incluir.Size = new System.Drawing.Size(86, 23);
            this.bt_Incluir.TabIndex = 3;
            this.bt_Incluir.Text = "Incluir";
            this.bt_Incluir.UseVisualStyleBackColor = true;
            this.bt_Incluir.Click += new System.EventHandler(this.bt_Incluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um Produto";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Limpar.Location = new System.Drawing.Point(12, 299);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(260, 23);
            this.bt_Limpar.TabIndex = 5;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Visualiza
            // 
            this.bt_Visualiza.Location = new System.Drawing.Point(12, 328);
            this.bt_Visualiza.Name = "bt_Visualiza";
            this.bt_Visualiza.Size = new System.Drawing.Size(260, 23);
            this.bt_Visualiza.TabIndex = 6;
            this.bt_Visualiza.Text = "Visualiza Produtos";
            this.bt_Visualiza.UseVisualStyleBackColor = true;
            this.bt_Visualiza.Click += new System.EventHandler(this.bt_Visualiza_Click);
            // 
            // bt_ValNum
            // 
            this.bt_ValNum.Location = new System.Drawing.Point(12, 357);
            this.bt_ValNum.Name = "bt_ValNum";
            this.bt_ValNum.Size = new System.Drawing.Size(260, 23);
            this.bt_ValNum.TabIndex = 7;
            this.bt_ValNum.Text = "Valor da Variável";
            this.bt_ValNum.UseVisualStyleBackColor = true;
            this.bt_ValNum.Click += new System.EventHandler(this.bt_ValNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.fNumericUpdDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressBarToolStripMenuItem,
            this.radiobuttonToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.componentesToolStripMenuItem_Click);
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click_1);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListaDeProdutos";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // fNumericUpdDownToolStripMenuItem
            // 
            this.fNumericUpdDownToolStripMenuItem.Name = "fNumericUpdDownToolStripMenuItem";
            this.fNumericUpdDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fNumericUpdDownToolStripMenuItem.Text = "NumericUpdDown";
            this.fNumericUpdDownToolStripMenuItem.Click += new System.EventHandler(this.fNumericUpdDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // progressBarToolStripMenuItem
            // 
            this.progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            this.progressBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressBarToolStripMenuItem.Text = "ProgressBar";
            this.progressBarToolStripMenuItem.Click += new System.EventHandler(this.progressBarToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuAtualizacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ProgramacaoC#";
            this.notifyIcon1.Visible = true;
            // 
            // MenuAtualizacoes
            // 
            this.MenuAtualizacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Restaurar,
            this.tsmi_Mensagem,
            this.tsmi_Fechar});
            this.MenuAtualizacoes.Name = "contextMenuStrip1";
            this.MenuAtualizacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuAtualizacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuAtualizacoes_ItemClicked);
            // 
            // tsmi_Restaurar
            // 
            this.tsmi_Restaurar.Name = "tsmi_Restaurar";
            this.tsmi_Restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Restaurar.Text = "Restaurar";
            // 
            // tsmi_Mensagem
            // 
            this.tsmi_Mensagem.Name = "tsmi_Mensagem";
            this.tsmi_Mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Mensagem.Text = "Mensagem";
            // 
            // tsmi_Fechar
            // 
            this.tsmi_Fechar.Name = "tsmi_Fechar";
            this.tsmi_Fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_Fechar.Text = "Fechar";
            // 
            // radiobuttonToolStripMenuItem
            // 
            this.radiobuttonToolStripMenuItem.Name = "radiobuttonToolStripMenuItem";
            this.radiobuttonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radiobuttonToolStripMenuItem.Text = "Radiobutton";
            this.radiobuttonToolStripMenuItem.Click += new System.EventHandler(this.radiobuttonToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 397);
            this.Controls.Add(this.bt_ValNum);
            this.Controls.Add(this.bt_Visualiza);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Incluir);
            this.Controls.Add(this.tb_ListaProd);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.Text = "Produtos Bass Som";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuAtualizacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Produto;
        private Button bt_Incluir;
        private Label label1;
        private Button bt_Limpar;
        private Button bt_Visualiza;
        private Button bt_ValNum;
        public TextBox tb_ListaProd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkboxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip MenuAtualizacoes;
        private ToolStripMenuItem tsmi_Restaurar;
        private ToolStripMenuItem tsmi_Mensagem;
        private ToolStripMenuItem tsmi_Fechar;
        private ToolStripMenuItem fNumericUpdDownToolStripMenuItem;
        private ToolStripMenuItem pictureBoxToolStripMenuItem;
        private ToolStripMenuItem progressBarToolStripMenuItem;
        private ToolStripMenuItem radiobuttonToolStripMenuItem;
    }
}