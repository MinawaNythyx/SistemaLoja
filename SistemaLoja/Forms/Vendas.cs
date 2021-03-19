using SistemaLoja.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLoja.Forms
{
    public partial class Vendas : Form
    {
        Produtos prod = new Produtos();
        public Vendas()
        {
            InitializeComponent();
        }

        private void sairVendasBtn_Click(object sender, EventArgs e)
        {
            FormMenu.sistema = true;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prodNome.Text = prodCod.Text;
            }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
