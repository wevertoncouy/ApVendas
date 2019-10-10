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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DbContext.Categoria;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.validaCategoria())
                this.categoriaBindingSource.EndEdit();
            DataContextFactory.DbContext.SubmitChanges();
            MessageBox.Show("Categoria inserida com sucesso!");

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir categoria", "Confirmação Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //if (this.CategoriarPossuiProduto(this.categorias))
                //{
                //    MessageBox.Show("Você não pode excluir essa categoria, porque existe produtos nela.");
                //}
                this.categoriaBindingSource.RemoveCurrent();
                DataContextFactory.DbContext.SubmitChanges();
                MessageBox.Show("Categoria excluida com sucesso!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private bool validaCategoria()
        {
            if (tbxCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Campo de categoria é obrigatório!");
                tbxCategoria.Focus();
                return false;
            }
            return true;
        }

        public Categoria categorias
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriarPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DbContext.Produto.Where(x => x.id_categoria == categoria.id_categoria);
            if (produtos.Count() > 0)
            {
                return true;
            }
            return false;
        }

    }
}
