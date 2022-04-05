namespace Projeto62Janelas
{
    partial class F_NumericUpdDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.bt_Valor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(12, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tb_Valor
            // 
            this.tb_Valor.Location = new System.Drawing.Point(143, 12);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(100, 23);
            this.tb_Valor.TabIndex = 1;
            this.tb_Valor.Text = "0";
            // 
            // bt_Valor
            // 
            this.bt_Valor.Location = new System.Drawing.Point(265, 12);
            this.bt_Valor.Name = "bt_Valor";
            this.bt_Valor.Size = new System.Drawing.Size(125, 23);
            this.bt_Valor.TabIndex = 2;
            this.bt_Valor.Text = "Definir Valor";
            this.bt_Valor.UseVisualStyleBackColor = true;
            this.bt_Valor.Click += new System.EventHandler(this.bt_DefinirValor_Click);
            // 
            // F_NumericUpdDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 47);
            this.Controls.Add(this.bt_Valor);
            this.Controls.Add(this.tb_Valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "F_NumericUpdDown";
            this.Text = "F_NumericUpdDown";
            this.Load += new System.EventHandler(this.F_NumericUpdDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox tb_Valor;
        private Button bt_Valor;
    }
}