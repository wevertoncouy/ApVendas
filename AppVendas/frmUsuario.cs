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
    public partial class frmUsuario : Form
    {
        public bool logado = false;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var loginUsuario = DataContextFactory.DbContext.tb_usuario.Count(
                x => x.usuario == tbxUsuario.Text && x.senha == tbxSenha.Text);

            if(loginUsuario > 0)
            {
                logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Nome de 'usuário' ou 'senha' está incorreto");
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
