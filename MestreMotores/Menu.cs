using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreMotores
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(resposta == DialogResult.No)
            {
                new FrmLogin().Show();
                Close();
            }
        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "CLIENTE";
            new frmListar().Show();
            Hide();
        }

        private void pctEspecialidade_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "ESPECIALIDADE";
            new frmListar().Show();
            Hide();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "FUNCIONÁRIO";
            new frmListar().Show();
            Hide();
        }

        private void pctMarca_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "MARCA";
            new frmListar().Show();
            Hide();
        }

        private void pctModelo_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "MODELO";
            new frmListar().Show();
            Hide();
        }

        private void pctVeiculo_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "VEÍCULO";
            new frmListar().Show();
            Hide();
        }

        private void pctPeca_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "PEÇA";
            new frmListar().Show();
            Hide();
        }

        private void pctServico_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "SERVIÇO";
            new frmListar().Show();
            Hide();
        }

        private void pctFornecedor_Click(object sender, EventArgs e)
        {
            variaveis.tabela = "FORNECEDOR";
            new frmListar().Show();
            Hide();
        }
    }
}
