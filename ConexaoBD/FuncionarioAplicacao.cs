using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class FuncionarioAplicacao
    {
        private Banco Banco;
        public void inserir(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Funcionario(nome, cargo, date, email)";
            strQuery += string.Format("VALUES ('{0}', '{1}', '{2}', '{3}')", funcionario.Nome, funcionario.Cargo, funcionario.Data, funcionario.Email);

            using(Banco = new Banco())
            {
                Banco.ExecutaComnadoSemRetorno(strQuery);
            }
        }

        public void Alterar(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "UPDATE Funcionario SET";
            strQuery += string.Format("Nome = '{0}'", funcionario.Nome);
            strQuery += string.Format("Cargo = '{0}'", funcionario.Cargo);
            strQuery += string.Format("Data = '{0}'", funcionario.Data);
            strQuery += string.Format("Email = '{0}'", funcionario.Email);

        }
    }
}
