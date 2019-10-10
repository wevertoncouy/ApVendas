namespace AppVendas
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatótiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnCadastroCategorias = new System.Windows.Forms.Button();
            this.btnCadastrarUsuarios = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatótiosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos / Categotias ";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.ProdutosToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.VendaToolStripMenuItem_Click);
            // 
            // relatótiosToolStripMenuItem
            // 
            this.relatótiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem2});
            this.relatótiosToolStripMenuItem.Name = "relatótiosToolStripMenuItem";
            this.relatótiosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatótiosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            this.produtosToolStripMenuItem2.Click += new System.EventHandler(this.ProdutosToolStripMenuItem2_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroProdutos.Image = global::AppVendas.Properties.Resources.CadastroCompras;
            this.btnCadastroProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastroProdutos.Location = new System.Drawing.Point(38, 38);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(113, 73);
            this.btnCadastroProdutos.TabIndex = 2;
            this.btnCadastroProdutos.Text = "Cadastrar Produtos";
            this.btnCadastroProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroProdutos.UseVisualStyleBackColor = true;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastroCategorias
            // 
            this.btnCadastroCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastroCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCategorias.Image = global::AppVendas.Properties.Resources.listaCategorias;
            this.btnCadastroCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastroCategorias.Location = new System.Drawing.Point(200, 38);
            this.btnCadastroCategorias.Name = "btnCadastroCategorias";
            this.btnCadastroCategorias.Size = new System.Drawing.Size(113, 73);
            this.btnCadastroCategorias.TabIndex = 3;
            this.btnCadastroCategorias.Text = "Cadastrar Categorias";
            this.btnCadastroCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroCategorias.UseVisualStyleBackColor = true;
            this.btnCadastroCategorias.Click += new System.EventHandler(this.btnCadastroCategorias_Click);
            // 
            // btnCadastrarUsuarios
            // 
            this.btnCadastrarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarUsuarios.Image = global::AppVendas.Properties.Resources.listaCategorias;
            this.btnCadastrarUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarUsuarios.Location = new System.Drawing.Point(354, 38);
            this.btnCadastrarUsuarios.Name = "btnCadastrarUsuarios";
            this.btnCadastrarUsuarios.Size = new System.Drawing.Size(113, 73);
            this.btnCadastrarUsuarios.TabIndex = 4;
            this.btnCadastrarUsuarios.Text = "Cadastrar Usuarios";
            this.btnCadastrarUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::AppVendas.Properties.Resources.fundo_sistemaDeGrade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 577);
            this.Controls.Add(this.btnCadastrarUsuarios);
            this.Controls.Add(this.btnCadastroCategorias);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnCadastroCategorias;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatótiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.Button btnCadastrarUsuarios;
    }
}

