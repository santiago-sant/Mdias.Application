using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDias.Application
{
    public partial class TelaLíder : Form
    {
        public TelaLíder()
        {
            InitializeComponent();
        }

        private void formTheme1_Click(object sender, EventArgs e)
        {

        }


        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }
                lider lider = new lider();
                lider.Nome = txtNome.Text;
                lider.Cpf = txtCPF.Text;
                lider.Senha = txtSenha.Text;
                lider.Endereco = txtEndereco.Text;
                lider.Telefone = txtTelefone.Text;

                if (lider.cadastrarLider())
                {
                    MessageBox.Show("Líder cadastrado com sucesso!");
                    txtNome.Clear();
                    txtCPF.Clear();
                    txtSenha.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar líder. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVoluntario = new TelaVoluntario();
            telaVoluntario.Show();
            this.Close();
        }

        private void editarVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleVoluntario telaControleVoluntario = new TelaControleVoluntario();
            telaControleVoluntario.Show();
            this.Close();
        }

        private void editarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleProjeto telaControleProjeto = new TelaControleProjeto();
            telaControleProjeto.Show();
            this.Close();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLíder telaLider = new TelaLíder();
            telaLider.Show();
            this.Close();
        }

        private void editarLIderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleLider telaControleLider = new TelaControleLider();
            telaControleLider.Show();
            this.Close();
        }

        private void TelaLíder_Load(object sender, EventArgs e)
        {
            if (sessao.TipoUsuario == "lider")
            {
                toolStripDropDownButton1.Visible = false; // <- aqui você oculta o item do MenuStrip
            }
        }
    }
}
