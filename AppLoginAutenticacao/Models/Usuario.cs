using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace AppLoginAutenticacao.Models
{
    public class Usuario
    {
        public int UsuarioID {  get; set; }

        [Required]
        [MaxLength(100)]
        public string UsuNome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(50)]
        public string Senha { get; set; }

        MySqlConnection conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexaolocaldatabase"].ConnectionString);
        MySqlCommand command = new MySqlCommand();    

        public void InsertUsuario(Usuario usuario) 
        {
            conexao.Open();
            command.CommandText = "call spInsertUsuario (@UsuNome, @Login, @Senha);";
            command.Parameters.Add("@UsuNome", MySqlDbType.VarChar).Value = usuario.UsuNome;
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuario.Login;
            command.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuario.Senha;
            command.Connection = conexao;
            command.ExecuteNonQuery();
            conexao.Close();
        }

        public string SelectLogin(string vLogin) 
        {
            conexao.Open();
            command.CommandText = "call spSelectLogin (@Login);";
            command.Parameters.Add("@Login", MySqlDbType.String).Value = vLogin;
            command.Connection = conexao;

            string Login = (string)command.ExecuteScalar();
            conexao.Close();
            if (Login == null)
                Login = "";

            return Login;
        }

        public Usuario SelectUsuario(string login) 
        { 
            return new Usuario(); 
        }

        public void UpdateSenha() 
        { 
        
        }

    }
}