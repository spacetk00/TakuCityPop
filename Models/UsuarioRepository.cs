using System;
using MySqlConnector;
using System.Collections.Generic;

namespace TakuCityPop.Models
{
    public class UsuarioRepository
    {
        private const string DadosConexao = "Database=taku_city;Data Source=localhost;User Id=root;";

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            System.Console.WriteLine("Banco de dados funcionando");
            Conexao.Close();
        }
        public void Cadastrar(Usuario usuario)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "INSERT INTO Usuario (Nome, Email, DataNascimento) VALUES (@Nome, @Email, @DataNascimento)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome",usuario.Nome);
            Comando.Parameters.AddWithValue("@Email",usuario.Email);
            Comando.Parameters.AddWithValue("@DataNascimento",usuario.DataNascimento);
            Comando.ExecuteNonQuery();


            Conexao.Close();
        }

        public List<Usuario> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            String Query = "SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
      
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>();

            while(Reader.Read())
            {
                Usuario UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                    UsuarioEncontrado.Email = Reader.GetString("Email");

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");

                Lista.Add(UsuarioEncontrado);

            }

            Conexao.Close();
            return Lista;
        }
    }
}