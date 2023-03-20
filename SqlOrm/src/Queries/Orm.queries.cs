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
        Console.WriteLine("This is my query");
    }
    // public string Read(IClient client, string query)
    // {
    //     using(client.getClient())
    //     {
    //         var command = new SqlCommand();
    //         command.CommandText = query;
    //         command.Connection = client.getClient();
    //         client.Open();
    //         var reader = command.ExecuteReader();
    //         while(reader.Read())
    //         {
    //             return reader.GetString(0);
    //         }
    //         client.Close();
    //     }
    // }

    // public void Insert(IClient client, string query)
    // {

    // }
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

