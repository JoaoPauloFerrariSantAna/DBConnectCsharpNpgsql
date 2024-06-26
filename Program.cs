using System;
using System.Reflection;
using Npgsql;

namespace Program {
	public class Program {
		public static void InsertUserData(string name, string email) {
			const string connString = "Host=localhost;Port=5432;Database=leaf;User Id=<DBUSER>;Password=<DBPASSWORD>;";

			using NpgsqlConnection conn = new NpgsqlConnection(connString);

			conn.Open();
			using var cmd = new NpgsqlCommand("INSERT INTO user_tbl (user_name, user_email) VALUES (@name, @email)", conn);

			cmd.Parameters.AddWithValue("name", name);
			cmd.Parameters.AddWithValue("email", email);

			cmd.ExecuteNonQuery();
		}

		public static void Main(string[] args) {
			string name = string.Empty;
			string email = string.Empty;

			Console.Write("Escreva o seu nome: ");
			name = Console.ReadLine();

			Console.Write("Escreva o seu email: ");
			email = Console.ReadLine();

			InsertUserData(name, email);

			Console.WriteLine("Informações cadastradas!");
			Console.WriteLine("Verifique o banco de dados.");
		}
	}
}
