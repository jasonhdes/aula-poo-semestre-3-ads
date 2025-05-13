using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreMotores
{
    public static class banco
    {
        //conexão banco
        public static string db =
            "SERVER=localhost;" +
            "USER=root;" +
            "DATABASE=db_mecanica";
        // reconhecer biblioteca MySQL
        public static MySqlConnection conexao;
        //abrir conexão com banco
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
                    }
            catch 
            {
                MessageBox.Show("Erro ao conectar com o banco");
            }
        }
        //fechar conexao
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao desconectar do banco");
            }
        }
    }
}
