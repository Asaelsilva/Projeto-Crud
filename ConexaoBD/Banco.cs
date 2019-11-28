using System;
using System.Collections.Generic;
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

        //Sempre sera executado quando minha classe for chamada.
        //Dispose: interface da IDisposable
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
