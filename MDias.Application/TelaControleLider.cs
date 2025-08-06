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
    public partial class TelaControleLider : Form
    {
        public TelaControleLider()
        {
            InitializeComponent();
        }
        private void TelaControleLider_Load(object sender, EventArgs e)
        {
            CarregarLider();
        }
        private void CarregarLider()
        {
                try
                {
                    DataTable lideres = lider.ListarLider();

                    dtgLider.Columns.Clear();
                    dtgLider.DataSource = null;
                    dtgLider.AutoGenerateColumns = false;

                    dtgLider.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Id_Lider",
                        HeaderText = "ID",
                        Name = "Id_Lider"
                    });

                    dtgLider.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Nome",
                        HeaderText = "Nome",
                        Name = "Nome"
                    });

                    dtgLider.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Cpf",
                        HeaderText = "CPF",
                        Name = "Cpf"
                    });

                    dtgLider.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Telefone",
                        HeaderText = "Telefone",
                        Name = "Telefone"
                    });

                    dtgLider.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = "Endereco",
                        HeaderText = "Endereço",
                        Name = "Endereco"
                    });

                    dtgLider.DataSource = lideres;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar líderes: " + ex.Message);
                }
            }
            
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaVoluntario telaVoluntario = new TelaVoluntario();
            telaVoluntario.Show();
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
    }
}