using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Locadora_Billgames
{
    internal class Connection
    {
        private string connstring = Connection.Database();
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        public static string UserId { get; set; }

        public static string Database()
        {
            return String.Format("Server={0};Port={1};" +
           "User Id={2};Password={3};Database={4};",
           "127.0.0.1", 5432, "postgres",
           "pgadmin", "ControlGamer");
        }

        public static string Verificar(string id, int pedido)
        {
            try 
            {
                string connstring = Connection.Database();
                NpgsqlConnection conn;
                string sql;
                NpgsqlCommand cmd;
                conn = new NpgsqlConnection(connstring);
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select * from users where id = @ID";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@ID", Convert.ToInt32(id)));
                Retorno = cmd.ExecuteReader();
                string retorna = null;
                if (Retorno.Read())
                {
                    
                    if(pedido == 0)
                    {
                        retorna = Retorno.GetString(Retorno.GetOrdinal("nome"));
                    }
                    if(pedido == 1)
                    {
                        retorna = Retorno.GetString(Retorno.GetOrdinal("Senha"));
                    }
                    if(pedido == 2)
                    {
                        retorna = Retorno.GetString(Retorno.GetOrdinal("Turno"));
                    }
                    if(pedido == 3)
                    {
                        retorna = Retorno.GetString(Retorno.GetOrdinal("Hierarquia"));

                    }
                    conn.Close();
                    return retorna;
                }
                else
                {
                    conn.Close();
                    return retorna;
                }
            }

            catch(Exception ex){
                return ex.Message;
            }
        }

        public string VerificarUnica(string valor, string local)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                NpgsqlDataReader Retorno;
                conn.Open();
                sql = "select * from console where nome = @Valor and local = @Local";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Add(new NpgsqlParameter("@Valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("@Local", local));
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
                //MessageBox.Show("Verifique seu banco de dados. Caso não consiga resolver: \nMande o erro para o suporte: \nContato: https://github.com/fuedgabriel");
                return "falseFalse: Erro:" + ex.Message.ToString();
            }
        }

    }
}
