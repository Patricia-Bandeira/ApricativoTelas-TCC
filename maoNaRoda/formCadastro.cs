using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maoNaRoda
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void brnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtGmail.Text == "" || txtSenha.Text == "" || txtConfirmSenha.Text == "")
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
            else if (txtSenha.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show("As senhas não conferem");
            }
            else
            {
                MessageBox.Show("Cadastro Realizado Com Sucesso!");
                FormMenu CarregarFormMenu = new FormMenu();
                CarregarFormMenu.Show();
                this.Hide();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormInicio CarregarFormInicio = new FormInicio();
            CarregarFormInicio.Show();
            this.Hide();
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
