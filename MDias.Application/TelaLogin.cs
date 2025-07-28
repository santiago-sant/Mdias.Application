namespace MDias.Application
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void formTheme1_Click(object sender, EventArgs e)
        {

        }

        private void spaceButton1_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
        }
    }
}
