namespace MDias.Application
{
    partial class TelaProjeto
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProjeto));
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            dtpData = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnCadastrar = new ReaLTaiizor.Controls.SpaceButton();
            txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
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
            crownToolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(dtpData);
            formTheme1.Controls.Add(btnCadastrar);
            formTheme1.Controls.Add(txtEndereco);
            formTheme1.Controls.Add(txtNome);
            formTheme1.Controls.Add(crownToolStrip1);
            formTheme1.Controls.Add(thunderControlBox1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Margin = new Padding(3, 2, 3, 2);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 21, 3, 21);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(700, 338);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.CenterScreen;
            formTheme1.TabIndex = 3;
            // 
            // dtpData
            // 
            dtpData.BorderRadius = 4;
            dtpData.Checked = true;
            dtpData.CustomizableEdges = customizableEdges1;
            dtpData.FillColor = Color.White;
            dtpData.Font = new Font("Segoe UI", 9F);
            dtpData.Format = DateTimePickerFormat.Long;
            dtpData.Location = new Point(367, 77);
            dtpData.Margin = new Padding(3, 2, 3, 2);
            dtpData.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpData.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpData.Size = new Size(285, 24);
            dtpData.TabIndex = 29;
            dtpData.Value = new DateTime(2025, 7, 25, 16, 23, 22, 604);
            // 
            // btnCadastrar
            // 
            btnCadastrar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnCadastrar.Font = new Font("Verdana", 8F);
            btnCadastrar.Image = null;
            btnCadastrar.Location = new Point(19, 249);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoRounding = false;
            btnCadastrar.Size = new Size(120, 40);
            btnCadastrar.TabIndex = 27;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlignment = HorizontalAlignment.Center;
            btnCadastrar.Transparent = false;
            btnCadastrar.Click += btnCadastrarVoluntarios_Click;
            // 
            // txtEndereco
            // 
            txtEndereco.BorderRadius = 4;
            txtEndereco.CustomizableEdges = customizableEdges3;
            txtEndereco.DefaultText = "";
            txtEndereco.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEndereco.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEndereco.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEndereco.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEndereco.FillColor = Color.FromArgb(224, 224, 224);
            txtEndereco.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEndereco.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEndereco.Location = new Point(19, 136);
            txtEndereco.Margin = new Padding(4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Endereço";
            txtEndereco.SelectedText = "";
            txtEndereco.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEndereco.Size = new Size(285, 23);
            txtEndereco.TabIndex = 10;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 4;
            txtNome.CustomizableEdges = customizableEdges5;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FillColor = Color.FromArgb(224, 224, 224);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(19, 78);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNome.Size = new Size(285, 23);
            txtNome.TabIndex = 6;
            // 
            // crownToolStrip1
            // 
            crownToolStrip1.AutoSize = false;
            crownToolStrip1.BackColor = Color.FromArgb(60, 63, 65);
            crownToolStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownToolStrip1.ImageScalingSize = new Size(20, 20);
            crownToolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton3, toolStripSeparator1, toolStripDropDownButton2, toolStripSeparator2, toolStripDropDownButton1 });
            crownToolStrip1.Location = new Point(3, 21);
            crownToolStrip1.Name = "crownToolStrip1";
            crownToolStrip1.Padding = new Padding(4, 0, 1, 0);
            crownToolStrip1.Size = new Size(694, 21);
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
            toolStripDropDownButton3.Size = new Size(74, 18);
            toolStripDropDownButton3.Text = "Voluntário";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            cadastrarToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(161, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // editarVToolStripMenuItem
            // 
            editarVToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarVToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarVToolStripMenuItem.Name = "editarVToolStripMenuItem";
            editarVToolStripMenuItem.Size = new Size(161, 22);
            editarVToolStripMenuItem.Text = "Editar Voluntário";
            editarVToolStripMenuItem.Click += editarVToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = Color.FromArgb(60, 63, 65);
            toolStripSeparator1.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 21);
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
            toolStripDropDownButton2.Size = new Size(58, 18);
            toolStripDropDownButton2.Text = "Projeto";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cadastrarToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(145, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // editarProjetoToolStripMenuItem
            // 
            editarProjetoToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarProjetoToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarProjetoToolStripMenuItem.Name = "editarProjetoToolStripMenuItem";
            editarProjetoToolStripMenuItem.Size = new Size(145, 22);
            editarProjetoToolStripMenuItem.Text = "Editar Projeto";
            editarProjetoToolStripMenuItem.Click += editarProjetoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = Color.FromArgb(60, 63, 65);
            toolStripSeparator2.ForeColor = Color.FromArgb(220, 220, 220);
            toolStripSeparator2.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 21);
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
            toolStripDropDownButton1.Size = new Size(46, 18);
            toolStripDropDownButton1.Text = "Lider";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cadastroToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(133, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // editarLIderToolStripMenuItem
            // 
            editarLIderToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editarLIderToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editarLIderToolStripMenuItem.Name = "editarLIderToolStripMenuItem";
            editarLIderToolStripMenuItem.Size = new Size(133, 22);
            editarLIderToolStripMenuItem.Text = "Editar LIder";
            editarLIderToolStripMenuItem.Click += editarLIderToolStripMenuItem_Click;
            // 
            // thunderControlBox1
            // 
            thunderControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            thunderControlBox1.BackColor = Color.Transparent;
            thunderControlBox1.DefaultLocation = true;
            thunderControlBox1.ForeColor = Color.White;
            thunderControlBox1.Location = new Point(633, 3);
            thunderControlBox1.Margin = new Padding(3, 2, 3, 2);
            thunderControlBox1.Name = "thunderControlBox1";
            thunderControlBox1.Size = new Size(64, 18);
            thunderControlBox1.TabIndex = 0;
            thunderControlBox1.Text = "thunderControlBox1";
            // 
            // TelaProjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(110, 38);
            Name = "TelaProjeto";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            crownToolStrip1.ResumeLayout(false);
            crownToolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.SpaceButton btnCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpData;
    }
}