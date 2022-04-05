namespace Projeto62Janelas
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.bt_ObterData = new System.Windows.Forms.Button();
            this.bt_SetarData = new System.Windows.Forms.Button();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Mes = new System.Windows.Forms.TextBox();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.by_DataAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(246, 23);
            this.dtp_data.TabIndex = 0;
            // 
            // bt_ObterData
            // 
            this.bt_ObterData.Location = new System.Drawing.Point(264, 11);
            this.bt_ObterData.Name = "bt_ObterData";
            this.bt_ObterData.Size = new System.Drawing.Size(88, 24);
            this.bt_ObterData.TabIndex = 1;
            this.bt_ObterData.Text = "Obter Data";
            this.bt_ObterData.UseVisualStyleBackColor = true;
            this.bt_ObterData.Click += new System.EventHandler(this.bt_ObterData_Click);
            // 
            // bt_SetarData
            // 
            this.bt_SetarData.Location = new System.Drawing.Point(264, 41);
            this.bt_SetarData.Name = "bt_SetarData";
            this.bt_SetarData.Size = new System.Drawing.Size(88, 23);
            this.bt_SetarData.TabIndex = 2;
            this.bt_SetarData.Text = "Setar Data";
            this.bt_SetarData.UseVisualStyleBackColor = true;
            this.bt_SetarData.Click += new System.EventHandler(this.bt_SetarData_Click);
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(12, 41);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(246, 23);
            this.tb_Data.TabIndex = 3;
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(12, 70);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(72, 23);
            this.tb_Dia.TabIndex = 4;
            // 
            // tb_Mes
            // 
            this.tb_Mes.Location = new System.Drawing.Point(105, 70);
            this.tb_Mes.Name = "tb_Mes";
            this.tb_Mes.Size = new System.Drawing.Size(72, 23);
            this.tb_Mes.TabIndex = 5;
            // 
            // tb_Ano
            // 
            this.tb_Ano.Location = new System.Drawing.Point(186, 70);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(72, 23);
            this.tb_Ano.TabIndex = 6;
            // 
            // by_DataAtual
            // 
            this.by_DataAtual.Location = new System.Drawing.Point(264, 70);
            this.by_DataAtual.Name = "by_DataAtual";
            this.by_DataAtual.Size = new System.Drawing.Size(88, 23);
            this.by_DataAtual.TabIndex = 7;
            this.by_DataAtual.Text = "Data Atual";
            this.by_DataAtual.UseVisualStyleBackColor = true;
            this.by_DataAtual.Click += new System.EventHandler(this.by_DataAtual_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 109);
            this.Controls.Add(this.by_DataAtual);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.tb_Mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.bt_SetarData);
            this.Controls.Add(this.bt_ObterData);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_DateTimePicker";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.F_DateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtp_data;
        private Button bt_ObterData;
        private Button bt_SetarData;
        private TextBox tb_Data;
        private TextBox tb_Dia;
        private TextBox tb_Mes;
        private TextBox tb_Ano;
        private Button by_DataAtual;
    }
}