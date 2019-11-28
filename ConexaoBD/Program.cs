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
            //SqlConnection conexao = new SqlConnection(@"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            //conexao.Open();

            //var numero = 0;
            //Console.WriteLine("Para listar todos os funcionarios digite 1");
            //Console.WriteLine("Para inserir um funcionarios digite 2");
            //Console.WriteLine("Para Alterar digite 3");
            //Console.WriteLine("Para Deletar digite 4");
            //numero = int.Parse(Console.ReadLine());


            //if (numero == 3)
            //{
            //    int id;

            //    Console.WriteLine("Digite o Id do funcionario que deseja alterar nome");
            //    id = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Altere o nome do funcionario para:");
            //    string nome = Console.ReadLine();


            //    string strQueryUpdate = "UPDATE Funcionario SET nome = '" + nome + "' WHERE usuarioId = " + numero + " ";
            //    SqlCommand comandoUpdate = new SqlCommand(strQueryUpdate, conexao);
            //    comandoUpdate.ExecuteNonQuery();
            //    //ExecuteNonQuery(): não tem retorno
            //}

            //if (numero == 4)
            //{
            //    string strQueryDelete = "DELETE FROM Funcionario WHERE usuarioId = 5";
            //    SqlCommand comandoDelete = new SqlCommand(strQueryDelete, conexao);
            //    comandoDelete.ExecuteNonQuery();
            //}



            //if (numero == 2)
            //{

            //    Console.WriteLine("Digite o nome do Funcionario: ");
            //    string nome = Console.ReadLine(); // Ira guardar o que o usuario digitou no console dento da variavel

            //    Console.WriteLine("Digite Cargo: ");
            //    string cargo = Console.ReadLine();// Ira guardar o que o usuario digitou no console dento da variavel

            //    Console.WriteLine("Digite Data nascimento: ");
            //    string dataNasc = Console.ReadLine();// Ira guardar o que o usuario digitou no console dento da variavel

            //    Console.WriteLine("Digite o email: ");
            //    string email = Console.ReadLine();// Ira guardar o que o usuario digitou no console dento da variavel

            //    string strQueryInsert = string.Format("INSERT INTO Funcionario(nome, cargo, date, email) VALUES('{0}','{1}', '{2}', '{3}')", nome, cargo, dataNasc, email);
            //    SqlCommand comandoInsert = new SqlCommand(strQueryInsert, conexao);
            //    comandoInsert.ExecuteNonQuery();
            //}



            //if (numero == 1)
            //{

            //    string strQuerySelect = "SELECT * FROM Funcionario";
            //    SqlCommand comandoSelect = new SqlCommand(strQuerySelect, conexao);
            //    SqlDataReader executaComando = comandoSelect.ExecuteReader();
            //    //SqlDataReader: Executor de dados, usado no comando SELECT
            //    //ExecuteReader(): retorna algo do banco

            //    //Read() : em quanto ouver dados faça a leitura
            //    while (executaComando.Read())
            //    {
            //        Console.WriteLine("Id: {0}, Nome: {1},Cargo: {2}, Data-Nasc: {3}, E-mail {4},", executaComando["usuarioId"], executaComando["nome"], executaComando["cargo"], executaComando["date"], executaComando["email"]);
            //    }

            //}


            Console.ReadLine();
        }
    }
}
