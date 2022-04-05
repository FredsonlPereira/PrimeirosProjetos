namespace Projeto62Janelas
{
    partial class F_PictureBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_BA = new System.Windows.Forms.Button();
            this.bt_BS = new System.Windows.Forms.Button();
            this.bt_Placa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto62Janelas.Properties.Resources.Bass_Acessorios;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_BA
            // 
            this.bt_BA.Location = new System.Drawing.Point(271, 98);
            this.bt_BA.Name = "bt_BA";
            this.bt_BA.Size = new System.Drawing.Size(159, 23);
            this.bt_BA.TabIndex = 6;
            this.bt_BA.Text = "Bass Acessórios";
            this.bt_BA.UseVisualStyleBackColor = true;
            this.bt_BA.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_BS
            // 
            this.bt_BS.Location = new System.Drawing.Point(271, 127);
            this.bt_BS.Name = "bt_BS";
            this.bt_BS.Size = new System.Drawing.Size(159, 23);
            this.bt_BS.TabIndex = 7;
            this.bt_BS.Text = "Bass Som";
            this.bt_BS.UseVisualStyleBackColor = true;
            this.bt_BS.Click += new System.EventHandler(this.bt_BS_Click);
            // 
            // bt_Placa
            // 
            this.bt_Placa.Location = new System.Drawing.Point(271, 166);
            this.bt_Placa.Name = "bt_Placa";
            this.bt_Placa.Size = new System.Drawing.Size(159, 23);
            this.bt_Placa.TabIndex = 8;
            this.bt_Placa.Text = "Placa de Propaganda";
            this.bt_Placa.UseVisualStyleBackColor = true;
            this.bt_Placa.Click += new System.EventHandler(this.bt_Placa_Click);
            // 
            // F_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 266);
            this.Controls.Add(this.bt_Placa);
            this.Controls.Add(this.bt_BS);
            this.Controls.Add(this.bt_BA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_PictureBox";
            this.Text = "F_PictureBox";
            this.Load += new System.EventHandler(this.F_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button bt_BA;
        private Button bt_BS;
        private Button bt_Placa;
    }
}