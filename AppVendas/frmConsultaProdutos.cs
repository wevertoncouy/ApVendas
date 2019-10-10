using sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVendas
{
    public partial class frmConsultaProdutos : Form
    {
        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        private void ProdutoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DbContext.Categoria;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.pesquisar((int)(cbxCategoria.SelectedValue));
        }

        public void pesquisar(int cadigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DbContext.Produto.Where(x => x.id_categoria == cadigoCategoria);
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)//Apagar
        {

        }
    }
}
