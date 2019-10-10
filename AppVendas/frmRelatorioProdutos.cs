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
    public partial class frmRelatorioProdutos : Form
    {
        public frmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DataSetRelatoriosProdutos.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.DataSetRelatoriosProdutos.tb_produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
