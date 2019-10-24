using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Locadora_Billgames
{
    public partial class Login : Form
    {
        private string connstring = Connection.Database();
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private string VerificarLogin(string User_name, string Pass_word)
        {
            try
            {
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select id from users where Nome = @User_name and Senha = @Pass_word";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@User_name", User_name));
                cmd.Parameters.Add(new NpgsqlParameter("@Pass_word", Pass_word));
                Retorno = cmd.ExecuteReader(); 
                
                if (Retorno.Read())
                {
                    int UserId = Retorno.GetInt32(Retorno.GetOrdinal("id"));
                    conn.Close();
                    return UserId.ToString();
                }
                else
                {
                    conn.Close();
                    return "false"; 
                }

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Erro: " + ex.Message);
                return "falseFalse";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User_name = User.Text;
            string Pass_word = Pass.Text;
            if(User_name == "" || Pass_word == "")
            {
                MessageBox.Show("Um dos campos está vazio\nDigite um usuário");
            }
            else
            {
                string id = VerificarLogin(User_name, Pass_word);
                if(id == "falseFalse")
                {
                    MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
                    
                }
                else if(id == "false")
                {
                    MessageBox.Show("Usuário ou senha incorreto");
                }
                else
                {
                    Dashboard.UserId = id;
                    Dashboard Dash = new Dashboard();
                    Dash.Show();
                    this.Hide();
                }
                
            }
            
        }  
    }
}
