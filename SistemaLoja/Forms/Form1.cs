using SistemaLoja.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja
{
    public partial class Form1 : Form
    {
        User usuario = new User();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400,200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(usuario.ValidateUser(loginBox.Text, passBox.Text))
            {
                MessageBox.Show("Login feito com sucesso");
                FormMenu.lgn = true;
                FormMenu.lgnOpen = false;
                FormMenu.sistema = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao logar");
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
