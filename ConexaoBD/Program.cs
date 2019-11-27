using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();

            string strQueryUpdate = "UPDATE Funcionario SET nome = 'Luan' WHERE usuarioId = 5";
            SqlCommand comandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            comandoUpdate.ExecuteNonQuery();
            //ExecuteNonQuery(): não tem retorno


            string strQuerySelect = "SELECT * FROM Funcionario";
            SqlCommand comandoSelect = new SqlCommand(strQuerySelect, conexao);
            SqlDataReader executaComando = comandoSelect.ExecuteReader();
            //SqlDataReader: Executor de dados, usado no comando SELECT
            //ExecuteReader(): retorna algo do banco

            //Read() : em quanto ouver dados faça a leitura
            while (executaComando.Read())
            {
                Console.WriteLine("Id: {0}, Nome: {1},Cargo: {2}, Data-Nasc: {3}, E-mail {4},", executaComando["usuarioId"], executaComando["nome"], executaComando["cargo"], executaComando["date"], executaComando["email"]);
            }

            Console.ReadLine();
        }
    }
}
