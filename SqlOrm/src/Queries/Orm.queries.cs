using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Connection;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;
using SqlOrm.Command;

namespace SqlOrm.Queries;


public class QueryClient : IQueryClient
{

    private readonly IClient _connectionClient;

    public QueryClient()
    {
        _connectionClient = new OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;");
    }

    public IEnumerable<string> Read(string query)
    {
        using(_connectionClient.getClient())
        {
            var command = new SqlCommand(query, _connectionClient.getClient());
            var list = new List<string>();
            _connectionClient.Open();
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                for(var i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader[i].ToString());
                }
            }
            return list;
            _connectionClient.Close();
            
        }
    }

    public void Insert(string query)
    {
        var command = new SqlCommand(query, _connectionClient.getClient());
        _connectionClient.Open();
        command.ExecuteNonQuery();
        _connectionClient.Close();
    }

}

public class QueryUtils<T>
{


    public static IEnumerable<T> Read(string query,string connection, IEnumerable<int> Campos)
    {
        IClient _connection = new OrmConnection(connection);
        using(_connection.getClient())
        {
            var comando = new SqlOrmCommand(query, _connection);
            var list = new List<T>();
            _connection.Open();
            var reader = comando.getReader();
            var count = 0;
            while(reader.Read())
            {
                list.Add(reader.GetFieldValue<T>(count));
                count++;
            }
            _connection.Close();
            return list;

        }
    }   
}
public partial class QueryBuilder : IRead<string>
{

    private readonly IQueryClient _queryClient;

    public QueryBuilder()
    {
        _queryClient = new QueryClient();
    }
    public virtual IEnumerable<string> GetAll()
    {
        var result = new List<string>();
        var query = _queryClient.Read("SELECT 'HOLA MUNDO' as Mensaje, 2+2 as Suma");
        foreach(var row in query)
        {
            Console.WriteLine(row);
        }
        return result;
    }

}

