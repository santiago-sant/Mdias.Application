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

        private void btnCadastrarVoluntarios_Click(object sender, EventArgs e)
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
    }
}
