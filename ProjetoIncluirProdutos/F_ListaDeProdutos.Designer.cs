namespace Projeto62Janelas
{
    partial class F_ListaDeProdutos
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1000",
            "AUTO FALANTE 6x9 HURRICANE CM 69",
            "10",
            "198,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1030",
            "BATERIA MOURA 100 HP",
            "5",
            "912,60"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "1228",
            "MODULO BOOG 1200",
            "7",
            "585,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1096",
            "CAIXA BOB BS 1 completa",
            "2",
            "1.800,00"}, -1);
            this.lv_Produtos = new System.Windows.Forms.ListView();
            this.col_Id = new System.Windows.Forms.ColumnHeader();
            this.Col_Produto = new System.Windows.Forms.ColumnHeader();
            this.col_Qde = new System.Windows.Forms.ColumnHeader();
            this.col_Preco = new System.Windows.Forms.ColumnHeader();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.tb_Qtde = new System.Windows.Forms.TextBox();
            this.tb_Preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Cadastro = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Produtos
            // 
            this.lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.Col_Produto,
            this.col_Qde,
            this.col_Preco});
            this.lv_Produtos.FullRowSelect = true;
            this.lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lv_Produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_Produtos.MultiSelect = false;
            this.lv_Produtos.Name = "lv_Produtos";
            this.lv_Produtos.Size = new System.Drawing.Size(642, 319);
            this.lv_Produtos.TabIndex = 0;
            this.lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.lv_Produtos.View = System.Windows.Forms.View.Details;
            this.lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.lv_Produtos_SelectedIndexChanged);
            // 
            // col_Id
            // 
            this.col_Id.Text = "ID";
            this.col_Id.Width = 40;
            // 
            // Col_Produto
            // 
            this.Col_Produto.Text = "DESCRIÇÃO DO PRODUTO";
            this.Col_Produto.Width = 300;
            // 
            // col_Qde
            // 
            this.col_Qde.Text = "QUANTIDADE";
            this.col_Qde.Width = 120;
            // 
            // col_Preco
            // 
            this.col_Preco.Text = "PREÇO";
            this.col_Preco.Width = 120;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(18, 364);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(41, 23);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_Produto
            // 
            this.tb_Produto.Location = new System.Drawing.Point(82, 364);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(300, 23);
            this.tb_Produto.TabIndex = 2;
            // 
            // tb_Qtde
            // 
            this.tb_Qtde.Location = new System.Drawing.Point(388, 364);
            this.tb_Qtde.Name = "tb_Qtde";
            this.tb_Qtde.Size = new System.Drawing.Size(120, 23);
            this.tb_Qtde.TabIndex = 3;
            // 
            // tb_Preco
            // 
            this.tb_Preco.Location = new System.Drawing.Point(514, 364);
            this.tb_Preco.Name = "tb_Preco";
            this.tb_Preco.Size = new System.Drawing.Size(120, 23);
            this.tb_Preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCRIÇÃO DO PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "PREÇO";
            // 
            // bt_Cadastro
            // 
            this.bt_Cadastro.Location = new System.Drawing.Point(18, 405);
            this.bt_Cadastro.Name = "bt_Cadastro";
            this.bt_Cadastro.Size = new System.Drawing.Size(146, 23);
            this.bt_Cadastro.TabIndex = 9;
            this.bt_Cadastro.Text = "Cadastrar";
            this.bt_Cadastro.UseVisualStyleBackColor = true;
            this.bt_Cadastro.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Location = new System.Drawing.Point(253, 405);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(146, 23);
            this.bt_Excluir.TabIndex = 10;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Pesquisar
            // 
            this.bt_Pesquisar.Location = new System.Drawing.Point(488, 405);
            this.bt_Pesquisar.Name = "bt_Pesquisar";
            this.bt_Pesquisar.Size = new System.Drawing.Size(146, 23);
            this.bt_Pesquisar.TabIndex = 11;
            this.bt_Pesquisar.Text = "Pesquisar";
            this.bt_Pesquisar.UseVisualStyleBackColor = true;
            this.bt_Pesquisar.Click += new System.EventHandler(this.bt_Pesquisar_Click);
            // 
            // F_ListaDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.bt_Pesquisar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Cadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Preco);
            this.Controls.Add(this.tb_Qtde);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lv_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListaDeProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.F_ListaDeProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_Produtos;
        private ColumnHeader col_Id;
        private ColumnHeader Col_Produto;
        private ColumnHeader col_Qde;
        private ColumnHeader col_Preco;
        private TextBox tb_Id;
        private TextBox tb_Produto;
        private TextBox tb_Qtde;
        private TextBox tb_Preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_Cadastro;
        private Button bt_Excluir;
        private Button bt_Pesquisar;
    }
}