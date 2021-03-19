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
            this.SuspendLayout();
            // 
            // sairVendasBtn
            // 
            this.sairVendasBtn.Location = new System.Drawing.Point(713, 12);
            this.sairVendasBtn.Name = "sairVendasBtn";
            this.sairVendasBtn.Size = new System.Drawing.Size(75, 23);
            this.sairVendasBtn.TabIndex = 0;
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
            this.prodCod.TabIndex = 1;
            this.prodCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // prodNome
            // 
            this.prodNome.Location = new System.Drawing.Point(114, 35);
            this.prodNome.MaxLength = 300;
            this.prodNome.Name = "prodNome";
            this.prodNome.Size = new System.Drawing.Size(133, 20);
            this.prodNome.TabIndex = 2;
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
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodNome);
            this.Controls.Add(this.prodCod);
            this.Controls.Add(this.sairVendasBtn);
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sairVendasBtn;
        private System.Windows.Forms.TextBox prodCod;
        private System.Windows.Forms.TextBox prodNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}