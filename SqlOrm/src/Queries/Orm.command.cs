using System.Data.Common;
using System.Data.SqlClient;
using SqlOrm.Interfaces.Connection;

namespace SqlOrm.Command;


    public abstract class OrmCommand<C, R, T> where C : DbCommand where R : DbDataReader
    where T : IClient 
    {
        public abstract R getReader();
    }


    public class SqlOrmCommand : OrmCommand<SqlCommand, SqlDataReader, IClient>
    {

        private readonly SqlCommand _comando;

        public SqlOrmCommand(string query, IClient client)
        {
            _comando = new SqlCommand(query, client.getClient());
        }

        public override SqlDataReader getReader()
        {
            return _comando.ExecuteReader();
        }
    }