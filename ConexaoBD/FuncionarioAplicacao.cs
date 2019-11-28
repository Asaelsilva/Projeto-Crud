﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class FuncionarioAplicacao
    {
        private Banco Banco;
        private void inserir(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO Funcionario(nome, cargo, date, email)";
            strQuery += string.Format("VALUES ('{0}', '{1}', '{2}', '{3}')", funcionario.Nome, funcionario.Cargo, funcionario.Data, funcionario.Email);

            using(Banco = new Banco())
            {
                Banco.ExecutaComnadoSemRetorno(strQuery);
            }
        }

        private void Alterar(Funcionario funcionario)
        {
            var strQuery = "";
            strQuery += "UPDATE Funcionario SET ";
            strQuery += string.Format("nome = '{0}',", funcionario.Nome);
            strQuery += string.Format("cargo = '{0}',", funcionario.Cargo);
            strQuery += string.Format("date = '{0}',", funcionario.Data);
            strQuery += string.Format("email = '{0}' ", funcionario.Email);
            strQuery += string.Format("WHERE usuarioId = '{0}'", funcionario.Id);

            using (Banco = new Banco())
            {
                Banco.ExecutaComnadoSemRetorno(strQuery);
            }
        }

        public void Salvar(Funcionario funcionario)
        {
            if (funcionario.Id > 0)
            {
                Alterar(funcionario);
            }
            else
            {
                inserir(funcionario);
            }
        }
    }
}