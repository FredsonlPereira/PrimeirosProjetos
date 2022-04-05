namespace Projeto62Janelas
{
    partial class F_PaiCheckBox
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
            this.cb_AutoFalante = new System.Windows.Forms.CheckBox();
            this.cb_Baterias = new System.Windows.Forms.CheckBox();
            this.cb_Cornetas = new System.Windows.Forms.CheckBox();
            this.cb_Modulos = new System.Windows.Forms.CheckBox();
            this.bt_TranspMarc = new System.Windows.Forms.Button();
            this.cb_FonteEnergia = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_AutoFalante
            // 
            this.cb_AutoFalante.AutoSize = true;
            this.cb_AutoFalante.Location = new System.Drawing.Point(12, 12);
            this.cb_AutoFalante.Name = "cb_AutoFalante";
            this.cb_AutoFalante.Size = new System.Drawing.Size(98, 19);
            this.cb_AutoFalante.TabIndex = 0;
            this.cb_AutoFalante.Text = "Auto Falantes";
            this.cb_AutoFalante.UseVisualStyleBackColor = true;
            // 
            // cb_Baterias
            // 
            this.cb_Baterias.AutoSize = true;
            this.cb_Baterias.Location = new System.Drawing.Point(12, 37);
            this.cb_Baterias.Name = "cb_Baterias";
            this.cb_Baterias.Size = new System.Drawing.Size(67, 19);
            this.cb_Baterias.TabIndex = 1;
            this.cb_Baterias.Text = "Baterias";
            this.cb_Baterias.UseVisualStyleBackColor = true;
            // 
            // cb_Cornetas
            // 
            this.cb_Cornetas.AutoSize = true;
            this.cb_Cornetas.Location = new System.Drawing.Point(12, 62);
            this.cb_Cornetas.Name = "cb_Cornetas";
            this.cb_Cornetas.Size = new System.Drawing.Size(73, 19);
            this.cb_Cornetas.TabIndex = 2;
            this.cb_Cornetas.Text = "Cornetas";
            this.cb_Cornetas.UseVisualStyleBackColor = true;
            // 
            // cb_Modulos
            // 
            this.cb_Modulos.AutoSize = true;
            this.cb_Modulos.Location = new System.Drawing.Point(12, 87);
            this.cb_Modulos.Name = "cb_Modulos";
            this.cb_Modulos.Size = new System.Drawing.Size(73, 19);
            this.cb_Modulos.TabIndex = 3;
            this.cb_Modulos.Text = "Módulos";
            this.cb_Modulos.UseVisualStyleBackColor = true;
            // 
            // bt_TranspMarc
            // 
            this.bt_TranspMarc.Location = new System.Drawing.Point(173, 12);
            this.bt_TranspMarc.Name = "bt_TranspMarc";
            this.bt_TranspMarc.Size = new System.Drawing.Size(154, 23);
            this.bt_TranspMarc.TabIndex = 4;
            this.bt_TranspMarc.Text = "Produtos Marcados";
            this.bt_TranspMarc.UseVisualStyleBackColor = true;
            this.bt_TranspMarc.Click += new System.EventHandler(this.bt_TranspMarc_Click);
            // 
            // cb_FonteEnergia
            // 
            this.cb_FonteEnergia.AutoSize = true;
            this.cb_FonteEnergia.Location = new System.Drawing.Point(12, 112);
            this.cb_FonteEnergia.Name = "cb_FonteEnergia";
            this.cb_FonteEnergia.Size = new System.Drawing.Size(114, 19);
            this.cb_FonteEnergia.TabIndex = 5;
            this.cb_FonteEnergia.Text = "Fonte de energia";
            this.cb_FonteEnergia.UseVisualStyleBackColor = true;
            this.cb_FonteEnergia.CheckedChanged += new System.EventHandler(this.cb_FonteEnergia_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Abrir F_Filho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_PaiCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_FonteEnergia);
            this.Controls.Add(this.bt_TranspMarc);
            this.Controls.Add(this.cb_Modulos);
            this.Controls.Add(this.cb_Cornetas);
            this.Controls.Add(this.cb_Baterias);
            this.Controls.Add(this.cb_AutoFalante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_PaiCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.Load += new System.EventHandler(this.F_CheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_TranspMarc;
        private CheckBox cb_FonteEnergia;
        public CheckBox cb_AutoFalante;
        public CheckBox cb_Baterias;
        public CheckBox cb_Cornetas;
        public CheckBox cb_Modulos;
        private Button button1;
    }
}