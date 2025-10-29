using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd;
            MySqlConnection conexao;
            string sql;
            conexao = new MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=teste01");
            try
            {
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("erro ao conectar no banco de dados" + ex.Message);
            }

            Pessoa p = new Pessoa();
            p.CadastrarUsuario();

            sql = "insert into Login1 values(" + p.id + ",'" + p.Nome + "','" + p.Senha + "');";
            cmd = new MySqlCommand(sql, conexao);
            int linhasafetadas;
            linhasafetadas = cmd.ExecuteNonQuery();
            Console.WriteLine("Linhas afetadas:{0}",linhasafetadas);

            sql = "Select * from Login1";
            cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            while (rdr.Read())
            {
                Console.WriteLine(rdr["id"] + " -- " + rdr["usuario"] + " -- " + rdr[2]);
            }
            rdr.Close();
            conexao.Close();

            
        }
    }
}
