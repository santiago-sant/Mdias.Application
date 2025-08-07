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
            if (sessao.TipoUsuario == "lider")
            {
                toolStripDropDownButton1.Visible = false; // <- aqui você oculta o item do MenuStrip
            }
        }

        private void PesquisarLideres()
        {
            string nomeBuscado = txtBuscar.Text.Trim(); // O que foi digitado no TextBox

            if (string.IsNullOrEmpty(nomeBuscado))
            {
                CarregarTodosLideres(); // Se o campo estiver vazio, carrega todos os líderes
                return;
            }

            try
            {
                // Chama a função que faz a consulta no banco
                DataTable lideres = lider.PesquisarLiderPorNome(nomeBuscado);

                dtgLider.DataSource = null;
                dtgLider.Rows.Clear();
                dtgLider.Columns.Clear();

                // Reconfigura as colunas do DataGridView
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

                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true,
                    Name = "Excluir"
                });

                // Botão Editar
                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Name = "Editar"
                });

                // Preenche os dados no DataGridView
                dtgLider.DataSource = lideres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar líderes: " + ex.Message);
            }
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

                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = true,
                    Name = "Excluir"
                });

                // Botão Editar
                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true,
                    Name = "Editar"
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

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Detecta quando pressionamos a tecla Enter
            {
                PesquisarLideres();  // Chama a função de pesquisa
                e.SuppressKeyPress = true;  // Impede o "beep" ao pressionar Enter
            }
        }

        private void CarregarTodosLideres()
        {
            try
            {
                DataTable lideres = lider.ListarLider();  // Método que retorna todos os líderes

                dtgLider.DataSource = null;
                dtgLider.Rows.Clear();
                dtgLider.Columns.Clear();

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

                // Botão Excluir
                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Excluir",
                    Name = "Excluir",
                    Text = "Excluir",
                    UseColumnTextForButtonValue = false
                });

                // Botão Editar
                dtgLider.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Editar",
                    Name = "Editar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                });
                // Preenche os dados com todos os líderes
                dtgLider.DataSource = lideres;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar todos os líderes: " + ex.Message);
            }
        }

        private void dtgLider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se clicou em uma célula de botão e em uma linha válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dtgLider.Columns[e.ColumnIndex].Name;
                int idLider = Convert.ToInt32(dtgLider.Rows[e.RowIndex].Cells["Id_Lider"].Value);

                if (columnName == "Excluir")
                {
                    DialogResult result = MessageBox.Show("Deseja realmente excluir este lider?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        lider Lider = new lider();
                        Lider.Id_Lider = idLider;

                        bool sucesso = Lider.excluirLider();
                        if (sucesso)
                        {
                            MessageBox.Show("lider excluído com sucesso!");
                            CarregarTodosLideres();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir lider.");
                        }
                    }
                }

                // Verifica se clicou no botão Editar
                if (columnName == "Editar")
                {
                    try
                    {
                        string nome = dtgLider.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();
                        string cpf = dtgLider.Rows[e.RowIndex].Cells["Cpf"].Value?.ToString();
                        string telefone = dtgLider.Rows[e.RowIndex].Cells["Telefone"].Value?.ToString();
                        string endereco = dtgLider.Rows[e.RowIndex].Cells["Endereco"].Value?.ToString();

                        // Monta o objeto líder
                        lider Lider = new lider();
                        Lider.Id_Lider = idLider;
                        Lider.Nome = nome;
                        Lider.Cpf = cpf;
                        Lider.Telefone = telefone;
                        Lider.Endereco = endereco;

                        // Atualiza o banco
                        bool sucesso = Lider.EditarLider();

                        if (sucesso)
                        {
                            MessageBox.Show("Líder atualizado com sucesso!");
                            CarregarLider();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar líder.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro na edição: " + ex.Message);
                    }
                }
            }
        }
    }
}