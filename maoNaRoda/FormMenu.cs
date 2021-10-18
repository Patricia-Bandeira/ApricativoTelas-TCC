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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FormComentarios CarregarFormComentarios = new FormComentarios();
            CarregarFormComentarios.Show();
            this.Hide();
        }

        private void btnSaúde_Click(object sender, EventArgs e)
        {
            FormSaude CarregarFormSaude= new FormSaude();
            CarregarFormSaude.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNotícias CarregarFormNoticias = new FormNotícias();
            CarregarFormNoticias.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCheckList CarregarFormChecklist = new FormCheckList();
            CarregarFormChecklist.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPercursos CarregarFormPercursos = new FormPercursos();
            CarregarFormPercursos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMapa CarregarFormMapa = new FormMapa();
            CarregarFormMapa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormInicio CarregarFormInicio = new FormInicio();
            CarregarFormInicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormComentarios CarregarFormComentarios = new FormComentarios();
            CarregarFormComentarios.Show();
            this.Hide();
        }
    }
}
