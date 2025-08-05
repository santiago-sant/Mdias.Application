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
    public partial class TelaProjeto : Form
    {
        public TelaProjeto()
        {
            InitializeComponent();
        }

        private void hopeDatePicker1_Click(object sender, EventArgs e)
        {
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVolutario = new TelaVoluntario();
            telaVolutario.Show();
            this.Hide();
        }

        private void editarVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleVoluntario telaControleVoluntario = new TelaControleVoluntario();
            telaControleVoluntario.Show();
            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
            this.Hide();
        }

        private void editarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleProjeto telaControleProjeto = new TelaControleProjeto();
            telaControleProjeto.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLíder telaLider = new TelaLíder();
            telaLider.Show();
            this.Hide();
        }

        private void editarLIderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleLider telaControleLider = new TelaControleLider();
            telaControleLider.Show();
            this.Hide();
        }

        private void btnCadastrarVoluntarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtEndereco.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                projeto projeto = new projeto();
                projeto.Nome = txtNome.Text;
                projeto.Endereco = txtEndereco.Text;
                projeto.Data_Realizacao = dtpData.Value;

                if (projeto.CadastrarProjeto())
                {
                    MessageBox.Show("Projeto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Clear();
                    txtEndereco.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o projeto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}