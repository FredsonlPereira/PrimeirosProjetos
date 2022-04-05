namespace Projeto62Janelas
{
    partial class F_CheckedListBox
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
            this.clb_Produtos = new System.Windows.Forms.CheckedListBox();
            this.bt_VisualizaProd = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Resetar = new System.Windows.Forms.Button();
            this.bt_NovosProdutos = new System.Windows.Forms.Button();
            this.tb_NovosProd = new System.Windows.Forms.TextBox();
            this.lb_NovosProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Produtos
            // 
            this.clb_Produtos.FormattingEnabled = true;
            this.clb_Produtos.Items.AddRange(new object[] {
            "Auto Falantes",
            "Baterias",
            "Cornetas",
            "Modulos"});
            this.clb_Produtos.Location = new System.Drawing.Point(12, 14);
            this.clb_Produtos.Name = "clb_Produtos";
            this.clb_Produtos.Size = new System.Drawing.Size(134, 220);
            this.clb_Produtos.TabIndex = 0;
            this.clb_Produtos.SelectedIndexChanged += new System.EventHandler(this.clb_Produtos_SelectedIndexChanged);
            // 
            // bt_VisualizaProd
            // 
            this.bt_VisualizaProd.Location = new System.Drawing.Point(165, 12);
            this.bt_VisualizaProd.Name = "bt_VisualizaProd";
            this.bt_VisualizaProd.Size = new System.Drawing.Size(222, 23);
            this.bt_VisualizaProd.TabIndex = 1;
            this.bt_VisualizaProd.Text = "Produtos Selecionados";
            this.bt_VisualizaProd.UseVisualStyleBackColor = true;
            this.bt_VisualizaProd.Click += new System.EventHandler(this.bt_VisualizaProd_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(165, 41);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(222, 23);
            this.bt_Limpar.TabIndex = 2;
            this.bt_Limpar.Text = "Limpar Produtos";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Resetar
            // 
            this.bt_Resetar.Location = new System.Drawing.Point(165, 70);
            this.bt_Resetar.Name = "bt_Resetar";
            this.bt_Resetar.Size = new System.Drawing.Size(222, 23);
            this.bt_Resetar.TabIndex = 3;
            this.bt_Resetar.Text = "Resetar Produtos";
            this.bt_Resetar.UseVisualStyleBackColor = true;
            this.bt_Resetar.Click += new System.EventHandler(this.bt_Resetar_Click);
            // 
            // bt_NovosProdutos
            // 
            this.bt_NovosProdutos.Location = new System.Drawing.Point(165, 210);
            this.bt_NovosProdutos.Name = "bt_NovosProdutos";
            this.bt_NovosProdutos.Size = new System.Drawing.Size(222, 23);
            this.bt_NovosProdutos.TabIndex = 4;
            this.bt_NovosProdutos.Text = "Adicionar Novos Produtos";
            this.bt_NovosProdutos.UseVisualStyleBackColor = true;
            this.bt_NovosProdutos.Click += new System.EventHandler(this.bt_NovosProdutos_Click);
            // 
            // tb_NovosProd
            // 
            this.tb_NovosProd.Location = new System.Drawing.Point(165, 181);
            this.tb_NovosProd.Name = "tb_NovosProd";
            this.tb_NovosProd.Size = new System.Drawing.Size(222, 23);
            this.tb_NovosProd.TabIndex = 5;
            this.tb_NovosProd.TextChanged += new System.EventHandler(this.tb_NovosProd_TextChanged);
            // 
            // lb_NovosProd
            // 
            this.lb_NovosProd.AutoSize = true;
            this.lb_NovosProd.Location = new System.Drawing.Point(165, 163);
            this.lb_NovosProd.Name = "lb_NovosProd";
            this.lb_NovosProd.Size = new System.Drawing.Size(140, 15);
            this.lb_NovosProd.TabIndex = 6;
            this.lb_NovosProd.Text = "Digite um Novo Produto:";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 256);
            this.Controls.Add(this.lb_NovosProd);
            this.Controls.Add(this.tb_NovosProd);
            this.Controls.Add(this.bt_NovosProdutos);
            this.Controls.Add(this.bt_Resetar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_VisualizaProd);
            this.Controls.Add(this.clb_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.Load += new System.EventHandler(this.F_CheckedListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox clb_Produtos;
        private Button bt_VisualizaProd;
        private Button bt_Limpar;
        private Button bt_Resetar;
        private Button bt_NovosProdutos;
        private TextBox tb_NovosProd;
        private Label lb_NovosProd;
    }
}