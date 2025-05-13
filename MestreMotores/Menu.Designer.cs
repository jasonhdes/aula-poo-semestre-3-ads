namespace MestreMotores
{
    partial class FrmMenu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pctFornecedor = new System.Windows.Forms.PictureBox();
            this.pctVeiculo = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctModelo = new System.Windows.Forms.PictureBox();
            this.pctEspecialidade = new System.Windows.Forms.PictureBox();
            this.pctPeca = new System.Windows.Forms.PictureBox();
            this.pctMarca = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEspecialidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 382);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(742, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(46, 46);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.lblUsuario.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(450, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(286, 46);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "USUÁRIO";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctFornecedor
            // 
            this.pctFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctFornecedor.Image = global::MestreMotores.Properties.Resources.btnFornecedor;
            this.pctFornecedor.Location = new System.Drawing.Point(304, 300);
            this.pctFornecedor.Name = "pctFornecedor";
            this.pctFornecedor.Size = new System.Drawing.Size(140, 140);
            this.pctFornecedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFornecedor.TabIndex = 8;
            this.pctFornecedor.TabStop = false;
            this.pctFornecedor.Click += new System.EventHandler(this.pctFornecedor_Click);
            // 
            // pctVeiculo
            // 
            this.pctVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctVeiculo.Image = global::MestreMotores.Properties.Resources.btnVeiculo;
            this.pctVeiculo.Location = new System.Drawing.Point(304, 153);
            this.pctVeiculo.Name = "pctVeiculo";
            this.pctVeiculo.Size = new System.Drawing.Size(140, 140);
            this.pctVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVeiculo.TabIndex = 7;
            this.pctVeiculo.TabStop = false;
            this.pctVeiculo.Click += new System.EventHandler(this.pctVeiculo_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctFuncionario.Image = global::MestreMotores.Properties.Resources.btnFuncionario;
            this.pctFuncionario.Location = new System.Drawing.Point(304, 6);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(140, 140);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuncionario.TabIndex = 6;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctServico
            // 
            this.pctServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctServico.Image = global::MestreMotores.Properties.Resources.btnServico;
            this.pctServico.Location = new System.Drawing.Point(158, 300);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(140, 140);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctServico.TabIndex = 5;
            this.pctServico.TabStop = false;
            this.pctServico.Click += new System.EventHandler(this.pctServico_Click);
            // 
            // pctModelo
            // 
            this.pctModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctModelo.Image = global::MestreMotores.Properties.Resources.btnModelo;
            this.pctModelo.Location = new System.Drawing.Point(158, 153);
            this.pctModelo.Name = "pctModelo";
            this.pctModelo.Size = new System.Drawing.Size(140, 140);
            this.pctModelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctModelo.TabIndex = 4;
            this.pctModelo.TabStop = false;
            this.pctModelo.Click += new System.EventHandler(this.pctModelo_Click);
            // 
            // pctEspecialidade
            // 
            this.pctEspecialidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctEspecialidade.Image = global::MestreMotores.Properties.Resources.btnEspecialidade;
            this.pctEspecialidade.Location = new System.Drawing.Point(158, 6);
            this.pctEspecialidade.Name = "pctEspecialidade";
            this.pctEspecialidade.Size = new System.Drawing.Size(140, 140);
            this.pctEspecialidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEspecialidade.TabIndex = 3;
            this.pctEspecialidade.TabStop = false;
            this.pctEspecialidade.Click += new System.EventHandler(this.pctEspecialidade_Click);
            // 
            // pctPeca
            // 
            this.pctPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctPeca.Image = global::MestreMotores.Properties.Resources.btnPecas;
            this.pctPeca.Location = new System.Drawing.Point(12, 301);
            this.pctPeca.Name = "pctPeca";
            this.pctPeca.Size = new System.Drawing.Size(140, 140);
            this.pctPeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPeca.TabIndex = 2;
            this.pctPeca.TabStop = false;
            this.pctPeca.Click += new System.EventHandler(this.pctPeca_Click);
            // 
            // pctMarca
            // 
            this.pctMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctMarca.Image = global::MestreMotores.Properties.Resources.btnMarca;
            this.pctMarca.Location = new System.Drawing.Point(12, 153);
            this.pctMarca.Name = "pctMarca";
            this.pctMarca.Size = new System.Drawing.Size(140, 140);
            this.pctMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMarca.TabIndex = 1;
            this.pctMarca.TabStop = false;
            this.pctMarca.Click += new System.EventHandler(this.pctMarca_Click);
            // 
            // pctCliente
            // 
            this.pctCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctCliente.Image = global::MestreMotores.Properties.Resources.btnCliente;
            this.pctCliente.Location = new System.Drawing.Point(12, 6);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(140, 140);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCliente.TabIndex = 0;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pctFornecedor);
            this.Controls.Add(this.pctVeiculo);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.pctServico);
            this.Controls.Add(this.pctModelo);
            this.Controls.Add(this.pctEspecialidade);
            this.Controls.Add(this.pctPeca);
            this.Controls.Add(this.pctMarca);
            this.Controls.Add(this.pctCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEspecialidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctMarca;
        private System.Windows.Forms.PictureBox pctPeca;
        private System.Windows.Forms.PictureBox pctEspecialidade;
        private System.Windows.Forms.PictureBox pctModelo;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.PictureBox pctVeiculo;
        private System.Windows.Forms.PictureBox pctFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblUsuario;
    }
}