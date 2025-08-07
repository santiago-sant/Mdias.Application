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
            try
            {
                if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    if (txtUsuario.Text.Equals("Adm", StringComparison.OrdinalIgnoreCase))
                    {
                        administrador adm = new administrador
                        {
                            Nome = txtUsuario.Text,
                            Senha = txtSenha.Text
                        };

                        int? idAdm = adm.verificarAdm(); // ← precisa retornar int?
                        if (idAdm.HasValue)
                        {
                            sessao.IdLogado = idAdm.Value;
                            sessao.TipoUsuario = "adm";

                            MessageBox.Show("Login de administrador realizado com sucesso!");

                            TelaPrincipal telaPrincipal = new TelaPrincipal();
                            telaPrincipal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                            txtUsuario.Clear();
                            txtSenha.Clear();
                        }
                    }
                    else
                    {
                        lider lider = new lider
                        {
                            Nome = txtUsuario.Text,
                            Senha = txtSenha.Text
                        };

                        int? idLider = lider.verificarLider(); // ← precisa retornar int?
                        if (idLider.HasValue)
                        {
                            sessao.IdLogado = idLider.Value;
                            sessao.TipoUsuario = "lider";

                            MessageBox.Show("Login de líder realizado com sucesso!");

                            TelaPrincipal telaPrincipal = new TelaPrincipal();
                            telaPrincipal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                            txtUsuario.Clear();
                            txtSenha.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        
    }
}