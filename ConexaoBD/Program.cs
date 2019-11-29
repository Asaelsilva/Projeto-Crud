using BDProjetoCrud.Dominio;
using System;
using BDPojetoCrud.Aplicacao;

namespace DOS
{
    class Program
    {
        static void Main(string[] args)
        {

           
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
