using MySql.Data.MySqlClient;
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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
        private void ListarCliente()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente ORDER BY nome_cliente";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Tipo";
                dtgListar.Columns[3].HeaderText = "CPF";
                dtgListar.Columns[4].HeaderText = "Data de Nasc";
                dtgListar.Columns[5].HeaderText = "email";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Telefone";
                dtgListar.Columns[8].HeaderText = "Endereço";
                dtgListar.Columns[9].HeaderText = "Bairro";
                dtgListar.Columns[10].HeaderText = "Cidade";
                dtgListar.Columns[11].HeaderText = "UF";
                dtgListar.Columns[12].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os clientes \n" + erro);
            }
        }
        private void ListarEspecialidade()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM tbl_especialidade ORDER BY nome_especialidade";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;


                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Especialidade";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar as especialidades \n" + erro);
            }
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            if (variaveis.tabela == "CLIENTE")
            {
                lblTabela.Text = "CLIENTE";
                ListarCliente();
            }
            else if (variaveis.tabela == "ESPECIALIDADE")
            {
                lblTabela.Text = "ESPECIALIDADE";
                ListarEspecialidade();
            }
            else if (variaveis.tabela == "FUNCIONÁRIO")
            {
                lblTabela.Text = "FUNCIONÁRIO";
            }
            else if (variaveis.tabela == "MARCA")
            {
                lblTabela.Text = "MARCA";
            }
            else if (variaveis.tabela == "MODELO")
            {
                lblTabela.Text = "MODELO";
            }
            else if (variaveis.tabela == "VEÍCULO")
            {
                lblTabela.Text = "VEÍCULO";
            }
            else if (variaveis.tabela == "PEÇA")
            {
                lblTabela.Text = "PEÇA";
            }
            else if (variaveis.tabela == "SERVIÇO")
            {
                lblTabela.Text = "SERVIÇO";
            }
            else if (variaveis.tabela == "FORNECEDOR")
            {
                lblTabela.Text = "FORNECEDOR";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Encerrar?", "ENCERRAR", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resposta == DialogResult.No)
            {
                new FrmLogin().Show();
                Close();
            }
        }
    }
}
