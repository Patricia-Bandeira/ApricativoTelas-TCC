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
    public partial class FormNotícias : Form
    {
        public FormNotícias()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu CarregarFormMenu = new FormMenu();
            CarregarFormMenu.Show();
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
