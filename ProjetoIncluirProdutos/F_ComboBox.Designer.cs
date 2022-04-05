namespace Projeto62Janelas
{
    partial class F_ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Produtos = new System.Windows.Forms.ComboBox();
            this.bt_MostrarSelecionados = new System.Windows.Forms.Button();
            this.bt_LimparProdutos = new System.Windows.Forms.Button();
            this.bt_ResetarProdutos = new System.Windows.Forms.Button();
            this.bt_NovoProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Produtos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_Produtos
            // 
            this.cb_Produtos.FormattingEnabled = true;
            this.cb_Produtos.Items.AddRange(new object[] {
            "Auto Falantes",
            "Baterias",
            "Cornetas",
            "Módulos"});
            this.cb_Produtos.Location = new System.Drawing.Point(12, 12);
            this.cb_Produtos.Name = "cb_Produtos";
            this.cb_Produtos.Size = new System.Drawing.Size(183, 23);
            this.cb_Produtos.TabIndex = 0;
            this.cb_Produtos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_MostrarSelecionados
            // 
            this.bt_MostrarSelecionados.Location = new System.Drawing.Point(201, 12);
            this.bt_MostrarSelecionados.Name = "bt_MostrarSelecionados";
            this.bt_MostrarSelecionados.Size = new System.Drawing.Size(183, 23);
            this.bt_MostrarSelecionados.TabIndex = 1;
            this.bt_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.bt_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.bt_MostrarSelecionados.Click += new System.EventHandler(this.bt_MostrarSelecionados_Click);
            // 
            // bt_LimparProdutos
            // 
            this.bt_LimparProdutos.Location = new System.Drawing.Point(201, 41);
            this.bt_LimparProdutos.Name = "bt_LimparProdutos";
            this.bt_LimparProdutos.Size = new System.Drawing.Size(183, 23);
            this.bt_LimparProdutos.TabIndex = 2;
            this.bt_LimparProdutos.Text = "Limpar Produtos";
            this.bt_LimparProdutos.UseVisualStyleBackColor = true;
            this.bt_LimparProdutos.Click += new System.EventHandler(this.bt_LimparProdutos_Click);
            // 
            // bt_ResetarProdutos
            // 
            this.bt_ResetarProdutos.Location = new System.Drawing.Point(201, 70);
            this.bt_ResetarProdutos.Name = "bt_ResetarProdutos";
            this.bt_ResetarProdutos.Size = new System.Drawing.Size(183, 23);
            this.bt_ResetarProdutos.TabIndex = 3;
            this.bt_ResetarProdutos.Text = "Resetar Produtos";
            this.bt_ResetarProdutos.UseVisualStyleBackColor = true;
            this.bt_ResetarProdutos.Click += new System.EventHandler(this.bt_ResetarProdutos_Click);
            // 
            // bt_NovoProduto
            // 
            this.bt_NovoProduto.Location = new System.Drawing.Point(201, 169);
            this.bt_NovoProduto.Name = "bt_NovoProduto";
            this.bt_NovoProduto.Size = new System.Drawing.Size(183, 23);
            this.bt_NovoProduto.TabIndex = 4;
            this.bt_NovoProduto.Text = "Incluir Novo Produto";
            this.bt_NovoProduto.UseVisualStyleBackColor = true;
            this.bt_NovoProduto.Click += new System.EventHandler(this.bt_NovoProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o Novo Produto";
            // 
            // tb_Produtos
            // 
            this.tb_Produtos.Location = new System.Drawing.Point(201, 140);
            this.tb_Produtos.Name = "tb_Produtos";
            this.tb_Produtos.Size = new System.Drawing.Size(183, 23);
            this.tb_Produtos.TabIndex = 6;
            this.tb_Produtos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 351);
            this.Controls.Add(this.tb_Produtos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_NovoProduto);
            this.Controls.Add(this.bt_ResetarProdutos);
            this.Controls.Add(this.bt_LimparProdutos);
            this.Controls.Add(this.bt_MostrarSelecionados);
            this.Controls.Add(this.cb_Produtos);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.Load += new System.EventHandler(this.F_ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cb_Produtos;
        private Button bt_MostrarSelecionados;
        private Button bt_LimparProdutos;
        private Button bt_ResetarProdutos;
        private Button bt_NovoProduto;
        private Label label1;
        private TextBox tb_Produtos;
    }
}