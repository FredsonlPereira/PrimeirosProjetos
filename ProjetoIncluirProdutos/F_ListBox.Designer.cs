namespace Projeto62Janelas
{
    partial class F_ListBox
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
            this.lb_Produtos = new System.Windows.Forms.ListBox();
            this.bt_Incluir = new System.Windows.Forms.Button();
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.bt_Obter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Produtos
            // 
            this.lb_Produtos.FormattingEnabled = true;
            this.lb_Produtos.ItemHeight = 15;
            this.lb_Produtos.Location = new System.Drawing.Point(12, 12);
            this.lb_Produtos.Name = "lb_Produtos";
            this.lb_Produtos.Size = new System.Drawing.Size(122, 229);
            this.lb_Produtos.TabIndex = 0;
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Location = new System.Drawing.Point(140, 60);
            this.bt_Incluir.Name = "bt_Incluir";
            this.bt_Incluir.Size = new System.Drawing.Size(100, 23);
            this.bt_Incluir.TabIndex = 1;
            this.bt_Incluir.Text = "Incluir";
            this.bt_Incluir.UseVisualStyleBackColor = true;
            this.bt_Incluir.Click += new System.EventHandler(this.bt_Incluir_Click);
            // 
            // tb_Produto
            // 
            this.tb_Produto.Location = new System.Drawing.Point(140, 31);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(100, 23);
            this.tb_Produto.TabIndex = 3;
            this.tb_Produto.TextChanged += new System.EventHandler(this.tb_Produto_TextChanged);
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(140, 90);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(100, 23);
            this.bt_Remover.TabIndex = 4;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            this.bt_Remover.Click += new System.EventHandler(this.bt_Remover_Click);
            // 
            // bt_Obter
            // 
            this.bt_Obter.Location = new System.Drawing.Point(140, 119);
            this.bt_Obter.Name = "bt_Obter";
            this.bt_Obter.Size = new System.Drawing.Size(100, 23);
            this.bt_Obter.TabIndex = 5;
            this.bt_Obter.Text = "Obter";
            this.bt_Obter.UseVisualStyleBackColor = true;
            this.bt_Obter.Click += new System.EventHandler(this.bt_Obter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(140, 148);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(100, 23);
            this.bt_Limpar.TabIndex = 7;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 271);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Obter);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.bt_Incluir);
            this.Controls.Add(this.lb_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.F_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_Produtos;
        private Button bt_Incluir;
        private TextBox tb_Produto;
        private Button bt_Remover;
        private Button bt_Obter;
        private Label label1;
        private Button bt_Limpar;
    }
}