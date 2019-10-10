namespace AppVendas
{
    partial class frmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label id_vendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label valor_pagoLabel;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label id_statusLabel;
            System.Windows.Forms.Label data_vencimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxIdVenda = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.GBVenda = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.contaReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxIdStatusPagamento = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.tbxValorPago = new System.Windows.Forms.TextBox();
            this.tbxDesconto = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.itenVendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            id_pessoaLabel = new System.Windows.Forms.Label();
            id_vendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            valor_pagoLabel = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            id_statusLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.GBVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenVendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Location = new System.Drawing.Point(19, 15);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(39, 13);
            id_pessoaLabel.TabIndex = 1;
            id_pessoaLabel.Text = "Cliente";
            // 
            // id_vendaLabel
            // 
            id_vendaLabel.AutoSize = true;
            id_vendaLabel.Location = new System.Drawing.Point(11, 22);
            id_vendaLabel.Name = "id_vendaLabel";
            id_vendaLabel.Size = new System.Drawing.Size(51, 13);
            id_vendaLabel.TabIndex = 0;
            id_vendaLabel.Text = "id venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(185, 49);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(29, 49);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "valor:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(191, 19);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(50, 13);
            id_produtoLabel.TabIndex = 10;
            id_produtoLabel.Text = " Produto:";
            // 
            // valor_pagoLabel
            // 
            valor_pagoLabel.AutoSize = true;
            valor_pagoLabel.Location = new System.Drawing.Point(273, 453);
            valor_pagoLabel.Name = "valor_pagoLabel";
            valor_pagoLabel.Size = new System.Drawing.Size(60, 13);
            valor_pagoLabel.TabIndex = 17;
            valor_pagoLabel.Text = "valor pago:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(445, 453);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(54, 13);
            descontoLabel.TabIndex = 15;
            descontoLabel.Text = "desconto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(466, 380);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(33, 13);
            valorLabel1.TabIndex = 13;
            valorLabel1.Text = "valor:";
            // 
            // id_statusLabel
            // 
            id_statusLabel.AutoSize = true;
            id_statusLabel.Location = new System.Drawing.Point(14, 383);
            id_statusLabel.Name = "id_statusLabel";
            id_statusLabel.Size = new System.Drawing.Size(64, 13);
            id_statusLabel.TabIndex = 21;
            id_statusLabel.Text = "Pagamento:";
            id_statusLabel.Click += new System.EventHandler(this.Id_statusLabel_Click);
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.Location = new System.Drawing.Point(15, 413);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(89, 13);
            data_vencimentoLabel.TabIndex = 22;
            data_vencimentoLabel.Text = "data vencimento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(sistema.DAL.Venda);
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "id_pessoa", true));
            this.cbxCliente.DataSource = this.pessoaBindingSource;
            this.cbxCliente.DisplayMember = "nome";
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(80, 12);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 2;
            this.cbxCliente.ValueMember = "id_pessoa";
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.CbxCliente_SelectedIndexChanged);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(sistema.DAL.Pessoa);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(230, 10);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.Button1_Click);
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(sistema.DAL.itenVenda);
            // 
            // tbxIdVenda
            // 
            this.tbxIdVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "id_venda", true));
            this.tbxIdVenda.Location = new System.Drawing.Point(68, 19);
            this.tbxIdVenda.Name = "tbxIdVenda";
            this.tbxIdVenda.ReadOnly = true;
            this.tbxIdVenda.Size = new System.Drawing.Size(100, 20);
            this.tbxIdVenda.TabIndex = 1;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "quantidade", true));
            this.tbxQuantidade.Location = new System.Drawing.Point(254, 46);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(121, 20);
            this.tbxQuantidade.TabIndex = 5;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(68, 46);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(sistema.DAL.Produto);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(431, 39);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoItem.TabIndex = 10;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.BtnNovoItem_Click);
            // 
            // GBVenda
            // 
            this.GBVenda.Controls.Add(this.btnFinalizar);
            this.GBVenda.Controls.Add(this.dtpDataVencimento);
            this.GBVenda.Controls.Add(data_vencimentoLabel);
            this.GBVenda.Controls.Add(id_statusLabel);
            this.GBVenda.Controls.Add(this.cbxIdStatusPagamento);
            this.GBVenda.Controls.Add(this.btnImprimir);
            this.GBVenda.Controls.Add(this.btnFinalizarVenda);
            this.GBVenda.Controls.Add(this.btnFinalizarPedido);
            this.GBVenda.Controls.Add(valor_pagoLabel);
            this.GBVenda.Controls.Add(this.tbxValorPago);
            this.GBVenda.Controls.Add(descontoLabel);
            this.GBVenda.Controls.Add(this.tbxDesconto);
            this.GBVenda.Controls.Add(valorLabel1);
            this.GBVenda.Controls.Add(this.tbxValor);
            this.GBVenda.Controls.Add(this.itenVendaDataGridView);
            this.GBVenda.Controls.Add(id_produtoLabel);
            this.GBVenda.Controls.Add(this.cbxProduto);
            this.GBVenda.Controls.Add(this.btnNovoItem);
            this.GBVenda.Controls.Add(valorLabel);
            this.GBVenda.Controls.Add(this.valorTextBox);
            this.GBVenda.Controls.Add(quantidadeLabel);
            this.GBVenda.Controls.Add(this.tbxQuantidade);
            this.GBVenda.Controls.Add(id_vendaLabel);
            this.GBVenda.Controls.Add(this.tbxIdVenda);
            this.GBVenda.Location = new System.Drawing.Point(15, 56);
            this.GBVenda.Name = "GBVenda";
            this.GBVenda.Size = new System.Drawing.Size(625, 519);
            this.GBVenda.TabIndex = 4;
            this.GBVenda.TabStop = false;
            this.GBVenda.Text = "Nova Venda";
            this.GBVenda.Visible = false;
            this.GBVenda.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(102, 476);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizar.TabIndex = 24;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contaReceberBindingSource, "data_vencimento", true));
            this.dtpDataVencimento.Location = new System.Drawing.Point(110, 407);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(110, 20);
            this.dtpDataVencimento.TabIndex = 23;
            // 
            // contaReceberBindingSource
            // 
            this.contaReceberBindingSource.DataSource = typeof(sistema.DAL.ContaReceber);
            // 
            // cbxIdStatusPagamento
            // 
            this.cbxIdStatusPagamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contaReceberBindingSource, "id_status", true));
            this.cbxIdStatusPagamento.DataSource = this.statusPagamentoBindingSource;
            this.cbxIdStatusPagamento.DisplayMember = "status";
            this.cbxIdStatusPagamento.FormattingEnabled = true;
            this.cbxIdStatusPagamento.Location = new System.Drawing.Point(81, 380);
            this.cbxIdStatusPagamento.Name = "cbxIdStatusPagamento";
            this.cbxIdStatusPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbxIdStatusPagamento.TabIndex = 22;
            this.cbxIdStatusPagamento.ValueMember = "id_status";
            this.cbxIdStatusPagamento.SelectedIndexChanged += new System.EventHandler(this.CbxIdStatusPagamento_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(sistema.DAL.StatusPagamento);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(339, 476);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 23);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Enabled = false;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(505, 476);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizarVenda.TabIndex = 20;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.BtnFinalizarVenda_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Location = new System.Drawing.Point(505, 403);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizarPedido.TabIndex = 19;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.BtnFinalizarPedido_Click);
            // 
            // tbxValorPago
            // 
            this.tbxValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor_pago", true));
            this.tbxValorPago.Location = new System.Drawing.Point(339, 450);
            this.tbxValorPago.Name = "tbxValorPago";
            this.tbxValorPago.ReadOnly = true;
            this.tbxValorPago.Size = new System.Drawing.Size(100, 20);
            this.tbxValorPago.TabIndex = 18;
            // 
            // tbxDesconto
            // 
            this.tbxDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "desconto", true));
            this.tbxDesconto.Location = new System.Drawing.Point(505, 450);
            this.tbxDesconto.Name = "tbxDesconto";
            this.tbxDesconto.ReadOnly = true;
            this.tbxDesconto.Size = new System.Drawing.Size(100, 20);
            this.tbxDesconto.TabIndex = 16;
            // 
            // tbxValor
            // 
            this.tbxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor", true));
            this.tbxValor.Location = new System.Drawing.Point(505, 377);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.ReadOnly = true;
            this.tbxValor.Size = new System.Drawing.Size(100, 20);
            this.tbxValor.TabIndex = 14;
            // 
            // itenVendaDataGridView
            // 
            this.itenVendaDataGridView.AllowUserToAddRows = false;
            this.itenVendaDataGridView.AllowUserToDeleteRows = false;
            this.itenVendaDataGridView.AutoGenerateColumns = false;
            this.itenVendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itenVendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.itenVendaDataGridView.DataSource = this.itemVendaBindingSource;
            this.itenVendaDataGridView.Location = new System.Drawing.Point(10, 101);
            this.itenVendaDataGridView.Name = "itenVendaDataGridView";
            this.itenVendaDataGridView.ReadOnly = true;
            this.itenVendaDataGridView.Size = new System.Drawing.Size(595, 270);
            this.itenVendaDataGridView.TabIndex = 11;
            this.itenVendaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItenVendaDataGridView_CellContentClick);
            this.itenVendaDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ItenVendaDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "id_produto", true));
            this.cbxProduto.DataSource = this.produtoBindingSource;
            this.cbxProduto.DisplayMember = "descricao_produto";
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(254, 16);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(121, 21);
            this.cbxProduto.TabIndex = 11;
            this.cbxProduto.ValueMember = "id_produto";
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.CbxProduto_SelectedIndexChanged);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 577);
            this.Controls.Add(this.GBVenda);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(id_pessoaLabel);
            this.Controls.Add(this.cbxCliente);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.GBVenda.ResumeLayout(false);
            this.GBVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenVendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.TextBox tbxIdVenda;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.GroupBox GBVenda;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView itenVendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.TextBox tbxValorPago;
        private System.Windows.Forms.TextBox tbxDesconto;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.ComboBox cbxIdStatusPagamento;
        private System.Windows.Forms.BindingSource contaReceberBindingSource;
        private System.Windows.Forms.DateTimePicker dtpDataVencimento;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
    }
}