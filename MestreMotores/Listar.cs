using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
                string selecionar = "SELECT id_cliente, nome_cliente, tipo_cliente, cpf_cnpj_cliente, data_nasc_cliente, email_cliente, senha_cliente, telefone_cliente, endereco_cliente, bairro_cliente, cidade_cliente, sigla_uf, id_status" +
                    " FROM tbl_cliente " +
                    " INNER JOIN tbl_uf ON tbl_cliente.id_uf = tbl_uf.id_uf ORDER BY nome_cliente";
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

        private void ListarFuncionario()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_funcionario, nome_funcionario, tipo_funcionario, cpf_cnpj_funcionario, data_adm_funcionario, email_funcionario, senha_funcionario, telefone_funcionario, endereco_funcionario, bairro_funcionario, cidade_funcionario, sigla_uf, nome_especialidade, salario_funcionario,id_status" +
                    " FROM tbl_funcionario " +
                    " INNER JOIN tbl_uf ON tbl_funcionario.id_uf = tbl_uf.id_uf " +
                    " INNER JOIN tbl_especialidade ON tbl_funcionario.id_especialidade = tbl_especialidade.id_especialidade " +
                    " ORDER BY nome_funcionario";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Tipo";
                dtgListar.Columns[3].HeaderText = "CPF";
                dtgListar.Columns[4].HeaderText = "Data Admissão";
                dtgListar.Columns[5].HeaderText = "email";
                dtgListar.Columns[6].Visible = false;
                dtgListar.Columns[7].HeaderText = "Telefone";
                dtgListar.Columns[8].HeaderText = "Endereço";
                dtgListar.Columns[9].HeaderText = "Bairro";
                dtgListar.Columns[10].HeaderText = "Cidade";
                dtgListar.Columns[11].HeaderText = "UF";
                dtgListar.Columns[12].HeaderText = "Salário";
                dtgListar.Columns[13].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os funcionarios \n" + erro);
            }
        }
        private void ListarMarca()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT * FROM tbl_marca ORDER BY nome_marca";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Marca";
                
                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar as marcas \n" + erro);
            }
        }
        private void ListarModelo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_modelo, nome_modelo, nome_marca" +
                    " FROM tbl_modelo " +
                    " INNER JOIN tbl_marca ON tbl_modelo.id_marca = tbl_marca.id_marca " +
                    " ORDER BY nome_modelo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Modelo";
                dtgListar.Columns[2].HeaderText = "Marca";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os modelos \n" + erro);
            }
        }
        private void ListarVeiculo()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_veiculo, nome_cliente, nome_modelo, placa_veiculo, ano_veiculo, combustivel_veiculo, chassi_veiculo, cor_veiculo, km_veiculo, tbl_veiculo.id_status " +
                    "FROM tbl_veiculo " +
                    "INNER JOIN tbl_cliente ON tbl_veiculo.id_cliente = tbl_cliente.id_cliente " +
                    "INNER JOIN tbl_modelo ON tbl_veiculo.id_modelo = tbl_modelo.id_modelo " + 
                    "ORDER BY tbl_veiculo.id_modelo";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Cliente";
                dtgListar.Columns[2].HeaderText = "Modelo";
                dtgListar.Columns[3].HeaderText = "Placa";
                dtgListar.Columns[4].HeaderText = "Ano";
                dtgListar.Columns[5].HeaderText = "Combustível";
                dtgListar.Columns[6].HeaderText = "Chassi";
                dtgListar.Columns[7].HeaderText = "Cor";
                dtgListar.Columns[8].HeaderText = "kms";
                dtgListar.Columns[9].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os veículos \n" + erro);
            }
        }
        private void ListarPeca()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_peca, nome_peca, descricao_peca, nome_fornecedor, valor_peca, qtde_estoque_peca, foto_peca, tbl_peca.id_status " + 
                    "FROM tbl_peca " + 
                    "INNER JOIN tbl_fornecedor ON tbl_fornecedor.id_fornecedor = tbl_peca.id_fornecedor " + 
                    "ORDER BY nome_peca";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Peça";
                dtgListar.Columns[2].HeaderText = "Descrição";
                dtgListar.Columns[3].HeaderText = "Fornecedor";
                dtgListar.Columns[4].HeaderText = "Preço";
                dtgListar.Columns[5].HeaderText = "Quantidade em Estoque";
                dtgListar.Columns[6].HeaderText = "Foto";
                dtgListar.Columns[7].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar as peças \n" + erro);
            }
        }
        private void ListarServico()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_servico, nome_servico, descricao_servico, preco_base_servico, tempo_estimado_servico, foto_servico, nome_especialidade, id_status " + 
                    "FROM tbl_servico "  + 
                    "INNER JOIN tbl_especialidade ON tbl_especialidade.id_especialidade = tbl_servico.id_especialidade " + 
                    "ORDER BY nome_servico";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Serviço";
                dtgListar.Columns[2].HeaderText = "Descrição";
                dtgListar.Columns[3].HeaderText = "Preço Base";
                dtgListar.Columns[4].HeaderText = "Tempo Estimado";
                dtgListar.Columns[5].HeaderText = "Foto";
                dtgListar.Columns[6].HeaderText = "Especialidade";
                dtgListar.Columns[7].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os serviços \n" + erro);
            }
        }
        private void ListarFornecedor()
        {
            try
            {
                banco.Conectar();
                string selecionar = "SELECT id_fornecedor, nome_fornecedor, tipo_fornecedor, cpf_cnpj_fornecedor, data_cad_fornecedor, email_fornecedor, site_fornecedor, telefone_fornecedor, endereco_fornecedor, bairro_fornecedor, cidade_fornecedor, sigla_uf, id_status " +
                    " FROM tbl_fornecedor " +
                    " INNER JOIN tbl_uf ON tbl_forncedor.id_uf = tbl_uf.id_uf ORDER BY nome_fornecedor";
                MySqlCommand cmd = new MySqlCommand(selecionar, banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgListar.DataSource = dt;

                dtgListar.Columns[0].HeaderText = "Código";
                dtgListar.Columns[1].HeaderText = "Nome";
                dtgListar.Columns[2].HeaderText = "Tipo";
                dtgListar.Columns[3].HeaderText = "CPF/CNPJ";
                dtgListar.Columns[4].HeaderText = "Data Cadastro";
                dtgListar.Columns[5].HeaderText = "Email";
                dtgListar.Columns[6].HeaderText = "Site do Fornecedor";
                dtgListar.Columns[7].HeaderText = "Telefone";
                dtgListar.Columns[8].HeaderText = "Endereço";
                dtgListar.Columns[9].HeaderText = "Bairro";
                dtgListar.Columns[10].HeaderText = "Cidade";
                dtgListar.Columns[11].HeaderText = "Estado";
                dtgListar.Columns[12].HeaderText = "Status";

                dtgListar.ClearSelection();
                banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar os fornecedores \n" + erro);
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
                ListarFuncionario();
            }
            else if (variaveis.tabela == "MARCA")
            {
                lblTabela.Text = "MARCA";
                ListarMarca();
            }
            else if (variaveis.tabela == "MODELO")
            {
                lblTabela.Text = "MODELO";
                ListarModelo();
            }
            else if (variaveis.tabela == "VEÍCULO")
            {
                lblTabela.Text = "VEÍCULO";
                ListarVeiculo();
            }
            else if (variaveis.tabela == "PEÇA")
            {
                lblTabela.Text = "PEÇA";
                ListarPeca();
            }
            else if (variaveis.tabela == "SERVIÇO")
            {
                lblTabela.Text = "SERVIÇO";
                ListarServico();
            }
            else if (variaveis.tabela == "FORNECEDOR")
            {
                lblTabela.Text = "FORNECEDOR";
                ListarFornecedor();
            }

            dtgListar.CellFormatting += dtgListar_CellFormatting;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new FrmMenu().Show();
                Close();
            
        }

        private void dtgListar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgListar.Columns[e.ColumnIndex].HeaderText == "Status")
            {
                if (e.Value !=  null)
                {
                    switch (e.Value.ToString())
                    {
                        case "1":
                            e.Value = "ATIVO";
                            e.FormattingApplied = true;
                            break;
                        case "2":
                            e.Value = "INATIVO";
                            e.FormattingApplied = true; 
                            break;
                        case "3":
                            e.Value = "DESATIVADO";
                            e.FormattingApplied = true;
                            break;
                    }
                }
            }
        }
    }
}
