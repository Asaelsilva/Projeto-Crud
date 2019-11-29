using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            using (Banco = new Banco())
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

        public void Excluir(int id)
        {
            using (Banco = new Banco())
            {
                var strQuery = string.Format("DELETE  FROM Funcionario WHERE usuarioId = {0}", id);
                Banco.ExecutaComnadoSemRetorno(strQuery);
            }
        }

        public List<Funcionario> Lista()
        {
            using (Banco = new Banco())
            {
                var strQuery = "SELECT * FROM Funcionario";
                var retorno = Banco.ExecutaComandoComRetorno(strQuery);
                return ReaderEmLista(retorno);
            }
        }
        
        private List<Funcionario>ReaderEmLista(SqlDataReader reader)
        {
            var funcionario = new List<Funcionario>();
            while (reader.Read())
            {
                var tempoObjeto = new Funcionario()
                {
                    Id = int.Parse(reader["usuarioId"].ToString()),
                    Nome = reader["nome"].ToString(),
                    Cargo = reader["cargo"].ToString(),
                    Data = DateTime.Parse(reader["date"].ToString()),
                    Email = reader["email"].ToString()
                };

                funcionario.Add(tempoObjeto);
            }
            reader.Close();
            return funcionario;
        }
    }
}
