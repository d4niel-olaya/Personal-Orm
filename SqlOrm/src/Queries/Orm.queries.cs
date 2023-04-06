using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Connection;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

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
    public static IEnumerable<T> Read(string query, string connection)
    {
        using(var conexion = new SqlConnection(connection))
        {
            var comando = new SqlCommand(query, conexion);
            var list = new List<T>();
            conexion.Open();
            var reader = comando.ExecuteReader();
            while(reader.Read())
            {
                // reading fields
            }
            conexion.Close();
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

