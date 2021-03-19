namespace SistemaLoja.Forms
{
    partial class Vendas
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
            this.sairVendasBtn = new System.Windows.Forms.Button();
            this.prodCod = new System.Windows.Forms.TextBox();
            this.prodNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listProd = new System.Windows.Forms.ListView();
            this.CodigoProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QtdProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sairVendasBtn
            // 
            this.sairVendasBtn.Location = new System.Drawing.Point(713, 12);
            this.sairVendasBtn.Name = "sairVendasBtn";
            this.sairVendasBtn.Size = new System.Drawing.Size(75, 23);
            this.sairVendasBtn.TabIndex = 1000;
            this.sairVendasBtn.Text = "Sair";
            this.sairVendasBtn.UseVisualStyleBackColor = true;
            this.sairVendasBtn.Click += new System.EventHandler(this.sairVendasBtn_Click);
            // 
            // prodCod
            // 
            this.prodCod.Location = new System.Drawing.Point(114, 90);
            this.prodCod.MaxLength = 13;
            this.prodCod.Name = "prodCod";
            this.prodCod.Size = new System.Drawing.Size(133, 20);
            this.prodCod.TabIndex = 0;
            this.prodCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // prodNome
            // 
            this.prodNome.Location = new System.Drawing.Point(114, 35);
            this.prodNome.MaxLength = 300;
            this.prodNome.Name = "prodNome";
            this.prodNome.Size = new System.Drawing.Size(133, 20);
            this.prodNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Produto :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo do Produto :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listProd);
            this.panel1.Location = new System.Drawing.Point(253, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 387);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listProd
            // 
            this.listProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoProduto,
            this.NomeProduto,
            this.QtdProduto,
            this.Preço});
            this.listProd.GridLines = true;
            this.listProd.HideSelection = false;
            this.listProd.Location = new System.Drawing.Point(3, 0);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(451, 384);
            this.listProd.TabIndex = 0;
            this.listProd.UseCompatibleStateImageBehavior = false;
            this.listProd.View = System.Windows.Forms.View.Details;
            this.listProd.SelectedIndexChanged += new System.EventHandler(this.listProd_SelectedIndexChanged);
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.Text = "Código do Produto";
            this.CodigoProduto.Width = 101;
            // 
            // NomeProduto
            // 
            this.NomeProduto.Text = "Nome do Produto";
            this.NomeProduto.Width = 224;
            // 
            // QtdProduto
            // 
            this.QtdProduto.Text = "Quantidade";
            this.QtdProduto.Width = 71;
            // 
            // Preço
            // 
            this.Preço.Text = "Valor";
            this.Preço.Width = 269;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodNome);
            this.Controls.Add(this.prodCod);
            this.Controls.Add(this.sairVendasBtn);
            this.Location = new System.Drawing.Point(300, 150);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairVendasBtn;
        private System.Windows.Forms.TextBox prodCod;
        private System.Windows.Forms.TextBox prodNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listProd;
        private System.Windows.Forms.ColumnHeader CodigoProduto;
        private System.Windows.Forms.ColumnHeader NomeProduto;
        private System.Windows.Forms.ColumnHeader QtdProduto;
        private System.Windows.Forms.ColumnHeader Preço;
    }
}