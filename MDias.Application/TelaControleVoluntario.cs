using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDias.Application
{
    public partial class TelaControleVoluntario : Form
    {
        

        public TelaControleVoluntario()
        {
            InitializeComponent();
          
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVolutario = new TelaVoluntario();
            telaVolutario.Show();
            this.Close();
        }

        private void editarVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaControleVoluntario telaControleVoluntario = new TelaControleVoluntario();
            telaControleVoluntario.Show();
            this.Close();
        }
            
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProjeto telaProjeto = new TelaProjeto();
            telaProjeto.Show();
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

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha clicada
                DataGridViewRow row = dgvVoluntario.Rows[e.RowIndex];

                // Acessa os dados das células e verifica se não são nulos antes de atribuir
                txtID.HeaderText = row.Cells["id_voluntario"].Value?.ToString() ?? string.Empty;  // ID do voluntário
                txtNome.HeaderText = row.Cells["Nome"].Value?.ToString() ?? string.Empty;  // Nome do voluntário
                txtTelefone.HeaderText = row.Cells["Telefone"].Value?.ToString() ?? string.Empty;  // Telefone do voluntário
                txtCpf.HeaderText = row.Cells["CPF"].Value?.ToString() ?? string.Empty;  // Cpf do voluntário
                txtEndereco.HeaderText = row.Cells["Endereço"].Value?.ToString() ?? string.Empty;  // Endereço do voluntário
                txtHabilidade.HeaderText = row.Cells["Habilidades"].Value?.ToString() ?? string.Empty;  // Habilidade do voluntário
                txtProjeto.HeaderText = row.Cells["Projetos"].Value?.ToString() ?? string.Empty;  // Relaciona Projeto com o voluntário
            }
        }

    }
    
}
