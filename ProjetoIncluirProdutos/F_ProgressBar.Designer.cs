namespace Projeto62Janelas
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bt_DefValor = new System.Windows.Forms.Button();
            this.tb_Inicio = new System.Windows.Forms.TextBox();
            this.bt_VerProgresso = new System.Windows.Forms.Button();
            this.tb_Fim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Contador = new System.Windows.Forms.TextBox();
            this.lb_Contador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // bt_DefValor
            // 
            this.bt_DefValor.Location = new System.Drawing.Point(12, 12);
            this.bt_DefValor.Name = "bt_DefValor";
            this.bt_DefValor.Size = new System.Drawing.Size(112, 23);
            this.bt_DefValor.TabIndex = 1;
            this.bt_DefValor.Text = "Definir Valor";
            this.bt_DefValor.UseVisualStyleBackColor = true;
            this.bt_DefValor.Click += new System.EventHandler(this.bt_DefValor_Click);
            // 
            // tb_Inicio
            // 
            this.tb_Inicio.Location = new System.Drawing.Point(163, 12);
            this.tb_Inicio.Name = "tb_Inicio";
            this.tb_Inicio.Size = new System.Drawing.Size(100, 23);
            this.tb_Inicio.TabIndex = 2;
            // 
            // bt_VerProgresso
            // 
            this.bt_VerProgresso.Location = new System.Drawing.Point(12, 95);
            this.bt_VerProgresso.Name = "bt_VerProgresso";
            this.bt_VerProgresso.Size = new System.Drawing.Size(123, 40);
            this.bt_VerProgresso.TabIndex = 3;
            this.bt_VerProgresso.Text = "Verificar Progresso";
            this.bt_VerProgresso.UseVisualStyleBackColor = true;
            this.bt_VerProgresso.Click += new System.EventHandler(this.bt_VerProgresso_Click);
            // 
            // tb_Fim
            // 
            this.tb_Fim.Location = new System.Drawing.Point(290, 12);
            this.tb_Fim.Name = "tb_Fim";
            this.tb_Fim.Size = new System.Drawing.Size(100, 23);
            this.tb_Fim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "À";
            // 
            // tb_Contador
            // 
            this.tb_Contador.Location = new System.Drawing.Point(163, 113);
            this.tb_Contador.Name = "tb_Contador";
            this.tb_Contador.Size = new System.Drawing.Size(100, 23);
            this.tb_Contador.TabIndex = 6;
            // 
            // lb_Contador
            // 
            this.lb_Contador.AutoSize = true;
            this.lb_Contador.Location = new System.Drawing.Point(177, 95);
            this.lb_Contador.Name = "lb_Contador";
            this.lb_Contador.Size = new System.Drawing.Size(70, 15);
            this.lb_Contador.TabIndex = 7;
            this.lb_Contador.Text = "CONTADOR";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Contador);
            this.Controls.Add(this.tb_Contador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Fim);
            this.Controls.Add(this.bt_VerProgresso);
            this.Controls.Add(this.tb_Inicio);
            this.Controls.Add(this.bt_DefValor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Button bt_DefValor;
        private TextBox tb_Inicio;
        private Button bt_VerProgresso;
        private TextBox tb_Fim;
        private Label label1;
        private TextBox tb_Contador;
        private Label lb_Contador;
    }
}