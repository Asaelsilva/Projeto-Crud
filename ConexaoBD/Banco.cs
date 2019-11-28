using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    class Banco : IDisposable
    {
        private readonly SqlConnection conexao;
        //readonly: Somente para leitura

        public Banco()
        {
            conexao = new SqlConnection(@"Data Source= DESKTOP-O34D68D\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ExemploBD");
            conexao.Open();
        }

        //Metodo que ira executar INSERT, UPDATE e DELETE do metodo sem retorno ExecuteNonQuery()
        public void ExecutaComnadoSemRetorno(string strQuery)
        {
            var comando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao
            };
        }

        //Metodo que ira executa SELECT do metodo com retorno ExecuteReader()
        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var comandoSelect = new SqlCommand(strQuery, conexao);
            return comandoSelect.ExecuteReader();
        }



        //Sempre sera executado quando minha classe for chamada.
        //Dispose: interface da IDisposable
        public void Dispose()
        {
            // Se estado  da conexao estiver aberta
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
    }
}
