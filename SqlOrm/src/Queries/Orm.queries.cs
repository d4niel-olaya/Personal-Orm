using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Connection;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace SqlOrm.Queries;


public class QueryClient
{
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
public partial class QueryBuilder 
{

    // private readonly IClient _connectionClient;

    // private readonly IQueryClient _queryClient;

    // public QueryBuilder()
    // {
    //     _connectionClient = new OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;");
    //     _queryClient = new QueryClient();
    // }
    // public virtual IEnumerable<string> GetAll()
    // {
    //     string query = $"SELECT * FROM {T.ToString()}";
    //     var result = new List<string>();
    //     result.Add(_queryClient.Read(_connectionClient, "SELECT 'HOLA MUNDO' as Mensaje"));
    //     return result;
    // }
}

