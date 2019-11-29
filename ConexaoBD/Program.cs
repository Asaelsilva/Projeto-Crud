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

            var banco = new Banco();
            var app = new FuncionarioAplicacao();

            Console.WriteLine("Digite o nome do Funcionario: ");
            string nome = Console.ReadLine(); 

            Console.WriteLine("Digite Cargo: ");
            string cargo = Console.ReadLine();

            Console.WriteLine("Digite Data nascimento: ");
            string dataNasc = Console.ReadLine();

            Console.WriteLine("Digite o email: ");
            string email = Console.ReadLine();

            var funcionarios = new Funcionario
            {
                Nome = nome,
                Cargo = cargo,
                Data = DateTime.Parse(dataNasc),
                Email = email
            };

            //funcionario.Id = 9;

            app.Salvar(funcionarios);
            var dados = app.Lista();

            
            foreach (var item in dados)
            {
                Console.WriteLine("Id: {0}, Nome: {1},Cargo: {2}, Data-Nasc: {3}, E-mail {4},", item.Id, item.Nome, item.Cargo, item.Data, item.Email);
            }

            Console.ReadLine();
        }
    }
}
