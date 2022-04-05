namespace Projeto61PrimJanExec
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
            this.lb_texto = new System.Windows.Forms.Label();
            this.bt_texto = new System.Windows.Forms.Button();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(19, 62);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(38, 15);
            this.lb_texto.TabIndex = 0;
            this.lb_texto.Text = "label1";
            // 
            // bt_texto
            // 
            this.bt_texto.Location = new System.Drawing.Point(19, 36);
            this.bt_texto.Name = "bt_texto";
            this.bt_texto.Size = new System.Drawing.Size(75, 23);
            this.bt_texto.TabIndex = 1;
            this.bt_texto.Text = "EXECUTAR";
            this.bt_texto.UseVisualStyleBackColor = true;
            this.bt_texto.Click += new System.EventHandler(this.bt_texto_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(19, 7);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(100, 23);
            this.tb_texto.TabIndex = 2;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.bt_texto);
            this.Controls.Add(this.lb_texto);
            this.Name = "F_Principal";
            this.Text = "Bass Som & Acessórios LTDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_texto;
        private Button bt_texto;
        private TextBox tb_texto;
    }
}