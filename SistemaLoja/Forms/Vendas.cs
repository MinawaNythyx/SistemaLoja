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
                string[] row = { prodCod.Text, prodCod.Text, prodCod.Text, prodCod.Text };
                var listview = new ListViewItem(row);
                listProd.Items.Add(listview);
                prodCod.Text = "";
            }
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}