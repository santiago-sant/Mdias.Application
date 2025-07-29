using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDias.Application
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
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
    }
}
