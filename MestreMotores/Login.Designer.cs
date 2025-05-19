namespace MestreMotores
{
    partial class FrmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pctMostrar = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctEmail = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pctMostrar);
            this.pnlLogin.Controls.Add(this.btnSair);
            this.pnlLogin.Controls.Add(this.btnEntrar);
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Location = new System.Drawing.Point(400, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 369);
            this.pnlLogin.TabIndex = 0;
            // 
            // pctMostrar
            // 
            this.pctMostrar.Image = global::MestreMotores.Properties.Resources.visualizar;
            this.pctMostrar.Location = new System.Drawing.Point(344, 238);
            this.pctMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctMostrar.Name = "pctMostrar";
            this.pctMostrar.Size = new System.Drawing.Size(27, 18);
            this.pctMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMostrar.TabIndex = 7;
            this.pctMostrar.TabStop = false;
            this.pctMostrar.Click += new System.EventHandler(this.pctMostrar_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(268, 293);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(37, 293);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(103, 36);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 49);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Login";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pctSenha);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Location = new System.Drawing.Point(37, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 49);
            this.panel2.TabIndex = 3;
            // 
            // pctSenha
            // 
            this.pctSenha.Image = global::MestreMotores.Properties.Resources.senha;
            this.pctSenha.Location = new System.Drawing.Point(0, 0);
            this.pctSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctSenha.Name = "pctSenha";
            this.pctSenha.Size = new System.Drawing.Size(53, 49);
            this.pctSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSenha.TabIndex = 1;
            this.pctSenha.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSenha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txtSenha.Location = new System.Drawing.Point(59, 12);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(268, 27);
            this.txtSenha.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pctEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(37, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 49);
            this.panel1.TabIndex = 2;
            // 
            // pctEmail
            // 
            this.pctEmail.Image = global::MestreMotores.Properties.Resources.email;
            this.pctEmail.Location = new System.Drawing.Point(0, 0);
            this.pctEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctEmail.Name = "pctEmail";
            this.pctEmail.Size = new System.Drawing.Size(53, 49);
            this.pctEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEmail.TabIndex = 1;
            this.pctEmail.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txtEmail.Location = new System.Drawing.Point(59, 12);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::MestreMotores.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(67, 62);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(267, 246);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMostrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pctMostrar;
        private System.Windows.Forms.Button btnSair;
    }
}

