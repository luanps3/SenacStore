namespace SenacStore.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            // Abrir o formulário de cadastro de usuários
            var tela = new frmUsuarios();
            tela.ShowDialog();
        }
    }
}
