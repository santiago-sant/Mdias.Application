namespace MDias.Application
{
    partial class TelaControleVoluntario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaControleVoluntario));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            dgvVoluntario = new Krypton.Toolkit.KryptonDataGridView();
            crownToolStrip1 = new ReaLTaiizor.Controls.CrownToolStrip();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            editarVToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            editarProjetoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            editarLIderToolStripMenuItem = new ToolStripMenuItem();
            thunderControlBox1 = new ReaLTaiizor.Controls.ThunderControlBox();
            formTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVoluntario).BeginInit();
            crownToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(txtBusca);
            formTheme1.Controls.Add(dgvVoluntario);
            formTheme1.Controls.Add(crownToolStrip1);
            formTheme1.Controls.Add(thunderControlBox1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(800, 451);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formTheme1.TabIndex = 3;
            // 
            // txtBusca
            // 
            txtBusca.BorderRadius = 4;
            txtBusca.CustomizableEdges = customizableEdges1;
            txtBusca.DefaultText = "";
            txtBusca.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBusca.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBusca.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBusca.FillColor = Color.FromArgb(224, 224, 224);
            txtBusca.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusca.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBusca.IconLeft = (Image)resources.GetObject("txtBusca.IconLeft");
            txtBusca.Location = new Point(21, 80);
            txtBusca.Margin = new Padding(5);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Nome";
            txtBusca.SelectedText = "";
            txtBusca.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBusca.Size = new Size(549, 31);
            txtBusca.TabIndex = 7;
            // 
            // dgvVoluntario
            // 
            dgvVoluntario.AllowUserToOrderColumns = true;
            dgvVoluntario.BorderStyle = BorderStyle.None;
            dgvVoluntario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoluntario.Location = new Point(11, 140);
            dgvVoluntario.Name = "dgvVoluntario";
            dgvVoluntario.RowHeadersWidth = 51;
            dgvVoluntario.Size = new Size(776, 277);
            dgvVoluntario.TabIndex = 2;
            dgvVoluntario.CellContentClick += kryptonDataGridView1_CellContentClick;
            // 
            // crownToolStrip1
            // 
            crownToolStrip1.AutoSize = false;
            crownToolStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownToolStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownToolStrip1.ImageScalingSize = new Size(20, 20);
            crownToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton3, toolStripSeparator1, toolStripDropDownButton2, toolStripSeparator2, toolStripDropDownButton1 });
            crownToolStrip1.Location = new Point(3, 28);
            crownToolStrip1.Name = "crownToolStrip1";
            crownToolStrip1.Padding = new Padding(5, 0, 1, 0);
            crownToolStrip1.Size = new Size(794, 28);
            crownToolStrip1.TabIndex = 1;
            crownToolStrip1.Text = "crownToolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.BackColor = Color.FromArgb(60, 63, 65);
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem1, editarVToolStripMenuItem });
            toolStripDropDownButton3.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(91, 25);
            toolStripDropDownButton3.Text = "Voluntário";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            cadastrarToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(203, 26);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // editarVToolStripMenuItem
            // 
            editarVToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarVToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarVToolStripMenuItem.Name = "editarVToolStripMenuItem";
            editarVToolStripMenuItem.Size = new Size(203, 26);
            editarVToolStripMenuItem.Text = "Editar Voluntário";
            editarVToolStripMenuItem.Click += editarVToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = Color.FromArgb(60, 63, 65);
            toolStripSeparator1.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.BackColor = Color.FromArgb(60, 63, 65);
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, editarProjetoToolStripMenuItem });
            toolStripDropDownButton2.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(71, 25);
            toolStripDropDownButton2.Text = "Projeto";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cadastrarToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(183, 26);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // editarProjetoToolStripMenuItem
            // 
            editarProjetoToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarProjetoToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarProjetoToolStripMenuItem.Name = "editarProjetoToolStripMenuItem";
            editarProjetoToolStripMenuItem.Size = new Size(183, 26);
            editarProjetoToolStripMenuItem.Text = "Editar Projeto";
            editarProjetoToolStripMenuItem.Click += editarProjetoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = Color.FromArgb(60, 63, 65);
            toolStripSeparator2.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = Color.FromArgb(60, 63, 65);
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, editarLIderToolStripMenuItem });
            toolStripDropDownButton1.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(56, 25);
            toolStripDropDownButton1.Text = "Lider";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cadastroToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(168, 26);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarLIderToolStripMenuItem
            // 
            editarLIderToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarLIderToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarLIderToolStripMenuItem.Name = "editarLIderToolStripMenuItem";
            editarLIderToolStripMenuItem.Size = new Size(168, 26);
            editarLIderToolStripMenuItem.Text = "Editar LIder";
            editarLIderToolStripMenuItem.Click += editarLIderToolStripMenuItem_Click;
            // 
            // thunderControlBox1
            // 
            thunderControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            thunderControlBox1.BackColor = Color.Transparent;
            thunderControlBox1.DefaultLocation = true;
            thunderControlBox1.ForeColor = Color.White;
            thunderControlBox1.Location = new Point(724, 3);
            thunderControlBox1.Name = "thunderControlBox1";
            thunderControlBox1.Size = new Size(73, 24);
            thunderControlBox1.TabIndex = 0;
            thunderControlBox1.Text = "thunderControlBox1";
            // 
            // TelaControleVoluntario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 51);
            Name = "TelaControleVoluntario";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVoluntario).EndInit();
            crownToolStrip1.ResumeLayout(false);
            crownToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private Krypton.Toolkit.KryptonDataGridView dgvVoluntario;
        private ReaLTaiizor.Controls.CrownToolStrip crownToolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem editarVToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem editarProjetoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem editarLIderToolStripMenuItem;
        private ReaLTaiizor.Controls.ThunderControlBox thunderControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
    }
}