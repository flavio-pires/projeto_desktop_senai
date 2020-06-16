using projeto_desktop_airsystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_desktop_airsystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tbxUsuario.ShortcutsEnabled = false;

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite o usuário", "Erro");
            }
            if (tbxSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Digite a senha", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipal().ShowDialog();

            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label4.Text = DateTime.Now.ToString("HH:mm:ss:ffff");
        }

    }
}
