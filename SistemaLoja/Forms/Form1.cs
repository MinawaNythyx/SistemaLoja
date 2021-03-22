using SistemaLoja.Codes;
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
        DBLoginConnect log = new DBLoginConnect();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400,200);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        #region Login
        public void Login()
        {
            if (log.LoginCnn(loginBox.Text, passBox.Text))
            {
                FormMenu.UsuarioGeral = loginBox.Text;
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
        #endregion
        #region Codigo Quebrado
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
