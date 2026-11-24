using SenacStore.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SenacStore.UI
{
    public partial class frmMenu : Form
    {
        private readonly Stack<UserControl> _historico = new Stack<UserControl>();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Abrir(new ucDashboard());
        }

        public void Abrir(UserControl controle)
        {
            panel.Controls.Clear();
            controle.Dock = DockStyle.Fill;
            panel.Controls.Add(controle);

            _historico.Push(controle);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Abrir(new ucUsuarios());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Abrir(new ucProdutos());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Abrir(new ucCategorias());
        }

        private void btnTipoUsuario_Click(object sender, EventArgs e)
        {
            Abrir(new ucTipoUsuario());
        }
    }
}
