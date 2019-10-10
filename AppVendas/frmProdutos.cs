
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema.DAL;

namespace AppVendas
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DbContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DbContext.Categoria;

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }



        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.validaProduto())
                this.produtoBindingSource.EndEdit();
            DataContextFactory.DbContext.SubmitChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Produto inserido com sucesso!");
        }
        private bool validaProduto()
        {
            if (tbxDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Campo de categoria é obrigatório!");
                tbxDescricao.Focus();
                return false;
            }
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir Produto", "Confirmação Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.produtoBindingSource.RemoveCurrent();
                DataContextFactory.DbContext.SubmitChanges();
                MessageBox.Show("Produto excluido com sucesso!");
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
            {
                e.Value = ((Categoria)e.Value).descricao_categoria;
            }
        }
    }
}
