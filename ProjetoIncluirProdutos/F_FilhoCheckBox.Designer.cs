namespace Projeto62Janelas
{
    partial class F_FilhoCheckBox
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
            this.cb_Modulos = new System.Windows.Forms.CheckBox();
            this.cb_Cornetas = new System.Windows.Forms.CheckBox();
            this.cb_Baterias = new System.Windows.Forms.CheckBox();
            this.cb_AutoFalante = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Modulos
            // 
            this.cb_Modulos.AutoSize = true;
            this.cb_Modulos.Location = new System.Drawing.Point(12, 87);
            this.cb_Modulos.Name = "cb_Modulos";
            this.cb_Modulos.Size = new System.Drawing.Size(73, 19);
            this.cb_Modulos.TabIndex = 7;
            this.cb_Modulos.Text = "Módulos";
            this.cb_Modulos.UseVisualStyleBackColor = true;
            this.cb_Modulos.CheckedChanged += new System.EventHandler(this.cb_Modulos_CheckedChanged);
            // 
            // cb_Cornetas
            // 
            this.cb_Cornetas.AutoSize = true;
            this.cb_Cornetas.Location = new System.Drawing.Point(12, 62);
            this.cb_Cornetas.Name = "cb_Cornetas";
            this.cb_Cornetas.Size = new System.Drawing.Size(73, 19);
            this.cb_Cornetas.TabIndex = 6;
            this.cb_Cornetas.Text = "Cornetas";
            this.cb_Cornetas.UseVisualStyleBackColor = true;
            this.cb_Cornetas.CheckedChanged += new System.EventHandler(this.cb_Cornetas_CheckedChanged);
            // 
            // cb_Baterias
            // 
            this.cb_Baterias.AutoSize = true;
            this.cb_Baterias.Location = new System.Drawing.Point(12, 37);
            this.cb_Baterias.Name = "cb_Baterias";
            this.cb_Baterias.Size = new System.Drawing.Size(67, 19);
            this.cb_Baterias.TabIndex = 5;
            this.cb_Baterias.Text = "Baterias";
            this.cb_Baterias.UseVisualStyleBackColor = true;
            this.cb_Baterias.CheckedChanged += new System.EventHandler(this.cb_Baterias_CheckedChanged);
            // 
            // cb_AutoFalante
            // 
            this.cb_AutoFalante.AutoSize = true;
            this.cb_AutoFalante.Location = new System.Drawing.Point(12, 12);
            this.cb_AutoFalante.Name = "cb_AutoFalante";
            this.cb_AutoFalante.Size = new System.Drawing.Size(98, 19);
            this.cb_AutoFalante.TabIndex = 4;
            this.cb_AutoFalante.Text = "Auto Falantes";
            this.cb_AutoFalante.UseVisualStyleBackColor = true;
            this.cb_AutoFalante.CheckedChanged += new System.EventHandler(this.cb_AutoFalante_CheckedChanged);
            // 
            // F_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 246);
            this.Controls.Add(this.cb_Modulos);
            this.Controls.Add(this.cb_Cornetas);
            this.Controls.Add(this.cb_Baterias);
            this.Controls.Add(this.cb_AutoFalante);
            this.Name = "F_FilhoCheckBox";
            this.Text = "F_FilhoCheckBox";
            this.Load += new System.EventHandler(this.F_FilhoCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_Modulos;
        private CheckBox cb_Cornetas;
        private CheckBox cb_Baterias;
        private CheckBox cb_AutoFalante;
    }
}