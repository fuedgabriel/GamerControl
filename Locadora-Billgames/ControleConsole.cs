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
            Reload();
        }

        private string Adicionar(string Nome, string Local, string Tipo)
        {
            try
            {
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select * from console_insert(@Nome, @Local, @Tipo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@Nome", Nome));
                cmd.Parameters.Add(new NpgsqlParameter("@Local", Local));
                cmd.Parameters.Add(new NpgsqlParameter("@Tipo", Tipo));
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

        public void Reload()
        {
            
            try
            {
                DataTable Adicionar = new DataTable();
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select id,Nome, local from console;";
                cmd = new NpgsqlCommand(sql, conn);
                Retorno = cmd.ExecuteReader();
                Adicionar.Columns.Add("Nome", typeof(string));
                ConsoleBox.DisplayMember = "Nome";
                while (Retorno.Read())
                {
                    string nome = Retorno.GetString(Retorno.GetOrdinal("nome"));
                    string local = Retorno.GetString(Retorno.GetOrdinal("local"));
                    int id = Retorno.GetInt16(Retorno.GetOrdinal("id"));
                    Adicionar.Rows.Add(nome +" " +local + " " + id );
                }
                ConsoleBox.DataSource = Adicionar;
                conn.Close();

            }
            catch (Exception ex)
            {
                //conn.Close();
                MessageBox.Show("Erro: " + ex.Message);
                MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
            }
            string[] VetNome = new string[10000];
            try
            {
                int i = 0;
                DataTable Adicionar = new DataTable();
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select Nome from console;";
                cmd = new NpgsqlCommand(sql, conn);
                Retorno = cmd.ExecuteReader();
                Adicionar.Columns.Add("Nome", typeof(string));
                ConsoleBox.DisplayMember = "Nome";
                while (Retorno.Read())
                {
                    VetNome[i] = Retorno.GetString(Retorno.GetOrdinal("nome"));
                    i++;
                }
                conn.Close();
                for (int a = 0; a > i; a++)
                {
                    //if (ConsolePreco.Contains(VetNome[a])) 
                }
            }
            catch(Exception es)
            {
                MessageBox.Show("Erro: " + es.Message);
                MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ConsoleBoxADD.Text == "" && LocalBox.Text == "" && TipoBox.Text == "")
            {
                MessageBox.Show("Possui algum campo vazio.");
            }
            else if (ConsoleBoxADD.Text.Contains(" ") || LocalBox.Text.Contains(" ") || TipoBox.Text.Contains(" "))
            {
                MessageBox.Show("Possui campos com espaço\nPara o funcionamento do programa é necessário que não possua espaço nos campos de inserção de valores.");
            }
            else
            {
                
                string VerificarExistencia = Teste.VerificarUnica(ConsoleBoxADD.Text ,LocalBox.Text);
                if(VerificarExistencia == "True")
                {
                    MessageBox.Show("Este valor já existe, digite outro.");
                }
                else if(VerificarExistencia == "false")
                {
                    string resultado = Adicionar(ConsoleBoxADD.Text, LocalBox.Text, TipoBox.Text);
                    if (resultado == "True")
                    {
                        MessageBox.Show("Cadastro efetuado.");
                    }
                    else if (resultado == "false")
                    {
                        MessageBox.Show("Algo no cadastro está errado.\nEx: PS4.");
                    }
                    else
                    {
                        MessageBox.Show(resultado.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Verifique o erro no arquivo connections.");
                }
            }
            ConsoleBoxADD.Text = "";
            LocalBox.Text = "";
            TipoBox.Text = "";
            Reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                string[] selecionado = new string[5];

                selecionado = ConsoleBox.Text.ToString().Split();
                DataTable Adicionar = new DataTable();
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "delete from console where id = @id;";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt16(selecionado[2])));
                Retorno = cmd.ExecuteReader();
                if (Retorno.Read() == false)
                {
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Erro ao excluir.");
                    conn.Close();

                }
                Reload();
            }
            catch(Exception es)
            {
                if(ConsoleBox.Text.ToString() == "")
                {
                    MessageBox.Show("Não possui valores inseridos");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Erro " + es.Message);
                    MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
                }
                
            }

                

        }
            


        private void button3_Click(object sender, EventArgs e)
        {
            if (NomeAlter.Text == "" || LocalAlter.Text == "" || TipoAlter.Text == "")
            {
                MessageBox.Show("Possui algum campo vazio.");
                goto passo;
            }
            else if (NomeAlter.Text.Contains(" ") || LocalAlter.Text.Contains(" ") || TipoAlter.Text.Contains(" "))
            {
                MessageBox.Show("Possui campos com espaço\nPara o funcionamento do programa é necessário que não possua espaço nos campos de inserção de valores.");
                goto passo;
            }
            string VerificarExistencia = Teste.VerificarUnica(ConsoleBoxADD.Text, LocalBox.Text);
            if (VerificarExistencia == "True")
            {
                MessageBox.Show("Este valor já existe, digite outro.");
            }
            else
            {

                try
                {
                    string[] selecionado = new string[5];

                    selecionado = ConsoleBox.Text.ToString().Split();
                    DataTable Adicionar = new DataTable();
                    NpgsqlDataReader Retorno;
                    conn.Open();
                    sql = "select * from console_update(@id, @Nome, @Local, @Tipo)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.Add(new NpgsqlParameter("@Nome", NomeAlter.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Local", LocalAlter.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Tipo", TipoAlter.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt16(selecionado[2])));
                    Retorno = cmd.ExecuteReader();
                    if (Retorno.Read() == false)
                    {
                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar.");
                        conn.Close();

                    }
                    Reload();
                }
                catch (Exception es)
                {
                    if (ConsoleBox.Text.ToString() == "")
                    {
                        MessageBox.Show("Não possui valores inseridos");
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro " + es.Message);
                        MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
                    }

                }
            }
            passo:
            NomeAlter.Text = "";
            LocalAlter.Text = "";
            TipoAlter.Text = "";
        }

        private void controlePreco1_Load(object sender, EventArgs e)
        {

        }
    }
}
