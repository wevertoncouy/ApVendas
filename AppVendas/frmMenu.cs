
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVendas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.Show();
        }

        private void btnCadastroCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.Show();
        }

        private void ProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProdutos frm = new frmConsultaProdutos();
            frm.Show();
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda frm = new frmVenda();
            frm.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ProdutosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioProdutos frm = new frmRelatorioProdutos();
               frm.Show();
        }
    }
}
