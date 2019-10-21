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
        private string connstring = String.Format("Server={0};Port={1};" +
           "User Id={2};Password={3};Database={4};",
           "127.0.0.1", 5432, "postgres",
           "pgadmin", "ControlGamer");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void VerificarLogin(String User_name, String Pass_word)
        {
            try
            {
                conn.Open();
                sql = String.Format("select Nome, Senha from users where Nome = '{0}' and Senha = '{1}'", User_name, Pass_word);
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
             
            }
            catch (Exception ex)
            {
                conn.Close();
                //MessageBox.Show("Erro: " + ex.Message);
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
                VerificarLogin(User_name, Pass_word);
                Dashboard Dash = new Dashboard();
                Dash.Show();
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
