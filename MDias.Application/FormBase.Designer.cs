namespace MDias.Application
{
    partial class FormBase
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
            BtnCadastrar = new Button();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.Location = new Point(195, 307);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(123, 72);
            BtnCadastrar.TabIndex = 0;
            BtnCadastrar.Text = "button1";
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 27);
            txtNome.TabIndex = 1;
            txtNome.Text = "N";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(94, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(275, 27);
            txtSenha.TabIndex = 2;
            txtSenha.Text = "S";
            // 
            // FormBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(BtnCadastrar);
            Name = "FormBase";
            Text = "FormBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCadastrar;
        private TextBox txtNome;
        private TextBox txtSenha;
    }
}