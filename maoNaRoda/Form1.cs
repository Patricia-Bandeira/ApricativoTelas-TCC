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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
            

        private void FormInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os dados");
            }
            else if (txtLogin.Text != "etec@gmail.com" || txtSenha.Text != "12345")
            {
                MessageBox.Show("Senha incorreta");
            }
            else
            {
                FormMenu CarregarFormMenu = new FormMenu();
                CarregarFormMenu.Show();
                this.Hide();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrarr_Click(object sender, EventArgs e)
        {
            formCadastro CarregarFormCadastro = new formCadastro();
            CarregarFormCadastro.Show();
            this.Hide();
        }
    }
}
