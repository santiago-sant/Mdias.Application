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
    public partial class TelaVoluntario : Form
    {
        public TelaVoluntario()
        {
            InitializeComponent();
        }

        private void kryptonMaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void formTheme1_Click(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrarVoluntarios_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtEndereco.Text) || string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtHabilidade.Text))
                {
                    MessageBox.Show("Preencha todos os campos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                voluntario Voluntario = new voluntario();

                Voluntario.Nome = txtNome.Text;
                Voluntario.Cpf = txtCPF.Text;
                Voluntario.Endereco = txtEndereco.Text;
                Voluntario.Telefone = txtTelefone.Text;
                Voluntario.Habilidade = txtHabilidade.Text;

                if (Voluntario.CadastrarVoluntario())
                {
                    MessageBox.Show("Voluntário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();
                    txtHabilidade.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar voluntário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}