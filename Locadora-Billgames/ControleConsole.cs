using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Locadora_Billgames
{
    
    public partial class ControleConsole : UserControl
    {
        private Connection teste = new Connection();
        private string connstring = Connection.Database();
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;

        internal Connection Teste { get => teste; set => teste = value; }

        public ControleConsole()

        {
            InitializeComponent();
        }
        private void ControleConsole_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private string Adicionar(string Nome)
        {
            try
            {
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select * from console_insert(@Nome)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@Nome", Nome));
                Retorno = cmd.ExecuteReader();
                if (Retorno.Read())
                {
                    conn.Close();
                    return "True";
                }
                else
                {
                    conn.Close();
                    return "false";
                }

            }
            catch (Exception ex)
            {
                //conn.Close();
                MessageBox.Show("Erro: " + ex.Message);
                MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
                return "falseFalse";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ConsoleBoxADD.Text == "") 
            { 
                MessageBox.Show("Nome não pode ser vazio");
            }
            else
            {
                
                string VerificarExistencia = Teste.VerificarUnica("console", "nome", ConsoleBoxADD.Text);
                if(VerificarExistencia == "True")
                {
                    MessageBox.Show("Este valor já existe, digite outro.");
                }
                else if(VerificarExistencia == "false")
                {
                    string resultado = Adicionar(ConsoleBoxADD.Text);
                    if (resultado == "True")
                    {
                        MessageBox.Show("Cadastro efetuado");
                    }
                    else if (resultado == "false")
                    {
                        MessageBox.Show("Algo no cadastro está errado\nEx: PS4");
                    }
                    else
                    {
                        MessageBox.Show(resultado.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o erro no arquivo connections");
                }
            }
            ConsoleBoxADD.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsoleBox.DataSource = "aaa";
        }
    }
}
