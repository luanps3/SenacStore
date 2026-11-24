namespace SenacStore.UI.UserControls
{
    partial class ucTipoUsuario
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
            btnCamcelar = new Guna.UI2.WinForms.Guna2Button();
            btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // btnCamcelar
            // 
            btnCamcelar.BorderRadius = 10;
            btnCamcelar.CustomizableEdges = customizableEdges1;
            btnCamcelar.DisabledState.BorderColor = Color.DarkGray;
            btnCamcelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCamcelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCamcelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCamcelar.FillColor = Color.DarkRed;
            btnCamcelar.Font = new Font("Segoe UI", 9F);
            btnCamcelar.ForeColor = Color.White;
            btnCamcelar.Location = new Point(301, 167);
            btnCamcelar.Name = "btnCamcelar";
            btnCamcelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCamcelar.Size = new Size(87, 45);
            btnCamcelar.TabIndex = 14;
            btnCamcelar.Text = "Cancelar";
            // 
            // btnSalvar
            // 
            btnSalvar.BorderRadius = 10;
            btnSalvar.CustomizableEdges = customizableEdges3;
            btnSalvar.DisabledState.BorderColor = Color.DarkGray;
            btnSalvar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSalvar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSalvar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSalvar.FillColor = Color.DarkGreen;
            btnSalvar.Font = new Font("Segoe UI", 9F);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(188, 167);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSalvar.Size = new Size(107, 45);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            // 
            // txtNome
            // 
            txtNome.BorderRadius = 10;
            txtNome.CustomizableEdges = customizableEdges5;
            txtNome.DefaultText = "";
            txtNome.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNome.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNome.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNome.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNome.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Font = new Font("Segoe UI", 9F);
            txtNome.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNome.Location = new Point(188, 125);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Tipo do Usuário";
            txtNome.SelectedText = "";
            txtNome.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNome.Size = new Size(200, 36);
            txtNome.TabIndex = 13;
            // 
            // ucTipoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCamcelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Name = "ucTipoUsuario";
            Size = new Size(595, 368);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCamcelar;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
    }
}
