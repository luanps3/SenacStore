namespace SenacStore.UI.UserControls
{
    partial class ucUsuarios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            cboTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            btnCamcelar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 10;
            btnSalvar.CustomizableEdges = customizableEdges1;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.FillColor = Color.DarkGreen;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(197, 249);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSalvar.Size = new Size(107, 45);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            // 
            // cboTipoUsuario
            // 
            cboTipoUsuario.BackColor = Color.Transparent;
            cboTipoUsuario.BorderRadius = 10;
            cboTipoUsuario.CustomizableEdges = customizableEdges3;
            cboTipoUsuario.DrawMode = DrawMode.OwnerDrawFixed;
            cboTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoUsuario.FocusedColor = Color.FromArgb(94, 148, 255);
            cboTipoUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboTipoUsuario.Font = new Font("Segoe UI", 10F);
            cboTipoUsuario.ForeColor = Color.FromArgb(68, 88, 112);
            cboTipoUsuario.ItemHeight = 30;
            cboTipoUsuario.Location = new Point(197, 200);
            cboTipoUsuario.Name = "cboTipoUsuario";
            cboTipoUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cboTipoUsuario.Size = new Size(200, 36);
            cboTipoUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.BorderRadius = 10;
            txtSenha.CustomizableEdges = customizableEdges5;
            txtSenha.DefaultText = "";
            txtSenha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSenha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSenha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSenha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Font = new Font("Segoe UI", 9F);
            txtSenha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSenha.Location = new Point(197, 158);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.SelectedText = "";
            txtSenha.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSenha.Size = new Size(200, 36);
            txtSenha.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.BorderRadius = 10;
            txtEmail.CustomizableEdges = customizableEdges7;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(197, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtEmail.Size = new Size(200, 36);
            txtEmail.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges9;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(197, 74);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.ScrollBars = ScrollBars.Both;
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNome.Size = new Size(200, 36);
            txtNome.TabIndex = 5;
            // 
            // btnCamcelar
            // 
            btnCamcelar.BorderRadius = 10;
            btnCamcelar.CustomizableEdges = customizableEdges11;
            btnCamcelar.DisabledState.BorderColor = Color.DarkGray;
            btnCamcelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCamcelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCamcelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCamcelar.FillColor = Color.DarkRed;
            btnCamcelar.Font = new Font("Segoe UI", 9F);
            btnCamcelar.ForeColor = Color.White;
            btnCamcelar.Location = new Point(310, 249);
            btnCamcelar.Name = "btnCamcelar";
            btnCamcelar.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCamcelar.Size = new Size(87, 45);
            btnCamcelar.TabIndex = 7;
            btnCamcelar.Text = "Cancelar";
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCamcelar);
            Controls.Add(btnSalvar);
            Controls.Add(cboTipoUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "ucUsuarios";
            Size = new Size(595, 368);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2ComboBox cboTipoUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2Button btnCamcelar;
    }
}
