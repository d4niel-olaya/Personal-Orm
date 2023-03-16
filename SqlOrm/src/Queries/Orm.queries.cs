using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Connection;
using System.Collections;
using System.Data.Common;

namespace SqlOrm.Queries;


public class QueryClient : IQueryClient
{
    public void Read()
    {
        
    }

    public void Insert()
    {

    }
}
public partial class QueryBuilder : IEditable<T>
{

    private readonly IClient _connectionClient;

    private readonly IQueryClient _queryClient;

    public QueryBuilder()
    {
        _connectionClient = new OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;");
    }
    public virtual IEnumerable<T> GetAll()
    {
        string query = $"SELECT * FROM {T.ToString()}";
        var command = new TDbCommand(query, _connectionClient.getClient);
        
    }
}

