namespace Projeto62Janelas
{
    partial class F_Produtos
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
            this.tb_ListaProdutos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ListaProdutos
            // 
            this.tb_ListaProdutos.Location = new System.Drawing.Point(2, 2);
            this.tb_ListaProdutos.Multiline = true;
            this.tb_ListaProdutos.Name = "tb_ListaProdutos";
            this.tb_ListaProdutos.Size = new System.Drawing.Size(360, 303);
            this.tb_ListaProdutos.TabIndex = 0;
            this.tb_ListaProdutos.TextChanged += new System.EventHandler(this.tb_ListaProdutos_TextChanged);
            // 
            // F_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 304);
            this.Controls.Add(this.tb_ListaProdutos);
            this.MaximizeBox = false;
            this.Name = "F_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Produtos_FormClosed);
            this.Load += new System.EventHandler(this.F_Produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_ListaProdutos;
    }
}