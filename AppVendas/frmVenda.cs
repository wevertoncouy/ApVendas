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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }


        private void FrmVenda_Load(object sender, EventArgs e)
        {
            Size = new Size(659, 154);
            this.pessoaBindingSource.DataSource = DataContextFactory.DbContext.Pessoa;
            this.produtoBindingSource.DataSource = DataContextFactory.DbContext.Produto;
            this.vendaBindingSource.DataSource = DataContextFactory.DbContext.Venda;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DbContext.StatusPagamento;
            this.contaReceberBindingSource.DataSource = DataContextFactory.DbContext.ContaReceber;
           
            this.vendaBindingSource.AddNew();
     
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Size = new Size(669, 616);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DbContext.SubmitChanges();
            GBVenda.Visible = true;
            btnNovaVenda.Enabled = false;
            cbxCliente.Enabled = false;

            this.itemVendaBindingSource.DataSource = DataContextFactory.DbContext.itenVenda.Where(x => x.id_produto == this.vendaCorrente.id_venda);
            NovoItem();

        }




        public Venda vendaCorrente// retorna oque tenho em vendas 
        {
            get { return (Venda)this.vendaBindingSource.Current; }
        }
        public itenVenda itemCorrente // vefiricar oque tenho dentro de item venda
        {
            get { return (itenVenda)this.itemVendaBindingSource.Current; }
        }

        public ContaReceber contaCorrente
        {
            get { return (ContaReceber)this.contaReceberBindingSource.Current; }
        }

        private void BtnNovoItem_Click(object sender, EventArgs e)
        {
            this.itenVendaDataGridView.EndEdit();
            itenVendaDataGridView.Refresh();
            DataContextFactory.DbContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();


        }

        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            this.itemCorrente.id_venda = this.vendaCorrente.id_venda;
            this.itemCorrente.quantidade = 1;
        }


        private void ItenVendaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
            {
                e.Value = ((Produto)e.Value).descricao_produto;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)//deletar
        {

        }

        private void CbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxProduto_SelectedIndexChanged(object sender, EventArgs e)//Produtos
        {
            if (cbxProduto.SelectedItem != null)
            {
                try
                { 
                    var produtos = (Produto)cbxProduto.SelectedItem;
                   this.itemCorrente.id_produto = (int)produtos.id_produto;//idProduto
                   this.itemCorrente.valor = (decimal)produtos.valor;//valorProduto
                }
                catch 
                {

                    MessageBox.Show("Selecione um produto!");
                }


            }
        }


        private void MostraSomaValores() // Soma Valorores
        {
            decimal total = 0;
            foreach (DataGridViewRow dataGrid in itenVendaDataGridView.Rows)
            {
                decimal valor1 = Convert.ToDecimal(dataGrid.Cells[2].Value);//Quantidade
                decimal valor2 = Convert.ToDecimal(dataGrid.Cells[3].Value);//Valor
                decimal subtotal = valor1 * valor2;
                dataGrid.Cells[4].Value = subtotal;
                total = total + subtotal;
            }

            vendaCorrente.valor = total;//ValorTotal
        }

        private void BtnFinalizarPedido_Click(object sender, EventArgs e)//Finalizar Pedido
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar pedido", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DbContext.SubmitChanges();
                vendaCorrente.desconto = 0; // inicio desconto  
                btnNovoItem.Enabled = false;
                cbxProduto.Enabled = false;
                tbxQuantidade.Enabled = false;
                tbxDesconto.ReadOnly = false;
                tbxDesconto.Focus();
                btnFinalizarPedido.Enabled = false;
                btnFinalizarVenda.Enabled = true;
                tbxIdVenda.Enabled = false;


            }
        }

        private void BtnFinalizarVenda_Click(object sender, EventArgs e) // finalizar Venda
        {
            vendaCorrente.desconto = Convert.ToDecimal(tbxDesconto.Text);
            vendaCorrente.valor_pago = (decimal)vendaCorrente.valor - vendaCorrente.desconto;
            vendaBindingSource.EndEdit();
            DataContextFactory.DbContext.SubmitChanges();
            tbxDesconto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
           


            cbxIdStatusPagamento.Enabled = true;
            contaReceberBindingSource.AddNew();
            contaCorrente.id_venda = vendaCorrente.id_venda;
            contaCorrente.data_compra = DateTime.Now;
            contaCorrente.data_vencimento = DateTime.Now;
        }

        private void Id_statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void CbxIdStatusPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIdStatusPagamento.SelectedItem != null)
            {
                var status = (StatusPagamento)cbxIdStatusPagamento.SelectedItem;
                if (status.id_status == 2)
                {
                    contaCorrente.id_status = (int)status.id_status;
                    contaCorrente.data_pagamento = DateTime.Now;
                    btnFinalizar.Enabled = true;
                    dtpDataVencimento.Enabled = false;// Date picker DataVencimenro
                }
                else if (status.id_status == 3)
                {
                    contaCorrente.id_status = (int)status.id_status;
                    contaCorrente.data_vencimento = DateTime.Now;
                    contaCorrente.data_pagamento = DateTime.Now;
                    contaCorrente.data_vencimento = null;
                    dtpDataVencimento.Enabled = true;
                    btnFinalizar.Enabled = true;
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            contaReceberBindingSource.EndEdit();
            dtpDataVencimento.Enabled = false;
            btnFinalizar.Enabled = false;
            cbxIdStatusPagamento.Enabled = false;
            btnImprimir.Enabled = true;
            DataContextFactory.DbContext.SubmitChanges();

            MessageBox.Show("Venda finalizada com sucesso!");
        }

        private void ItenVendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            /// Irmprimir venda
        }
    }

}
