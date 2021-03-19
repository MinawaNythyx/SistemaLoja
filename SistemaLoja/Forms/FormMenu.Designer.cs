namespace SistemaLoja.Forms
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.vendaBtn = new System.Windows.Forms.Button();
            this.sairMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // vendaBtn
            // 
            this.vendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendaBtn.Location = new System.Drawing.Point(12, 12);
            this.vendaBtn.Name = "vendaBtn";
            this.vendaBtn.Size = new System.Drawing.Size(150, 80);
            this.vendaBtn.TabIndex = 0;
            this.vendaBtn.Text = "Vendas";
            this.vendaBtn.UseVisualStyleBackColor = true;
            this.vendaBtn.Click += new System.EventHandler(this.vendaBtn_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairMenu.Location = new System.Drawing.Point(638, 358);
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(150, 80);
            this.sairMenu.TabIndex = 1;
            this.sairMenu.Text = "Sair";
            this.sairMenu.UseVisualStyleBackColor = true;
            this.sairMenu.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.sairMenu);
            this.Controls.Add(this.vendaBtn);
            this.Location = new System.Drawing.Point(300, 100);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button vendaBtn;
        private System.Windows.Forms.Button sairMenu;
    }
}