using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Show_do_Pila
{
    public class banco
    {
        private static string conexao = @"server = localhost; database = jogo; uid = root; pwd = 'root'";

        public static bool VerificarLogin(string login, string senha) { 
        
            using (MySqlConnection bdConn = new MySqlConnection(conexao))
            {
                try
                {
                    bdConn.Open();

                    if (bdConn.State == System.Data.ConnectionState.Open)
                    {
                        string SQL = "SELECT Login FROM usuarios WHERE Login = '" + login + "' AND Senha = '" + senha + "';";


                        MySqlCommand comando = new MySqlCommand(SQL, bdConn);
 
                        MySqlDataReader r = comando.ExecuteReader();


                        if (r.Read())
                        {
                            bdConn.Close();
                            return true;
                        }
                        r.Close();
                    }

                    else throw new Exception("Banco inacessivel");
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

                return false;
            }
        }


        public static questao BuscaPergunta()
        {

            using (MySqlConnection bdConn = new MySqlConnection(conexao))
            {
                try
                {
                    bdConn.Open();

                    if (bdConn.State == System.Data.ConnectionState.Open)
                    {
                        string questao = "SELECT * FROM perguntas ORDER BY RAND() LIMIT 1;";

                        MySqlCommand comando = new MySqlCommand(questao, bdConn);

                        MySqlDataReader r = comando.ExecuteReader();

                        if (r.Read())
                        {
                            questao x = new questao(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4));
                            bdConn.Close();
                            return x;
                        }
                        r.Close();
                    }

                    else throw new Exception("Banco inacessivel");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //return false;
                }

                return null;
            }
        }

        public static questao BuscaPergunta(string id)
        {

            using (MySqlConnection bdConn = new MySqlConnection(conexao))
            {
                try
                {
                    bdConn.Open();

                    if (bdConn.State == System.Data.ConnectionState.Open)
                    {
                        string questao = "SELECT * FROM perguntas WHERE Id=" + id;

                        MySqlCommand comando = new MySqlCommand(questao, bdConn);

                        MySqlDataReader r = comando.ExecuteReader();

                        if (r.Read())
                        {
                            questao x = new questao(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4));
                            bdConn.Close();
                            return x;
                        }
                        r.Close();
                    }

                    else throw new Exception("Banco inacessivel");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //return false;
                }

                return null;
            }
        }

    }
}