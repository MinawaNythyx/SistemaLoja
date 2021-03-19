using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja.Forms
{
    public partial class FormMenu : Form
    {
        public static bool lgn;
        public static bool lgnOpen;
        public static bool sistema;
        Form1 form1 = new Form1();

        public FormMenu()
        {
            InitializeComponent();
            lgn = false;
            lgnOpen = false;
            sistema = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(lgnOpen == false)
            {
                form1.Show();
                lgnOpen = true;
            }
        }

        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lgn == false & lgnOpen == false)
            {
                form1.Show();
                lgnOpen = true;
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(sistema == true)
            {
                this.Show();
                sistema = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer3.Enabled = false;
        }
        #endregion

        private void vendaBtn_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
            this.Hide();
        }
    }
}
