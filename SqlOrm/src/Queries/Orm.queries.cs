using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Connection;
using System.Collections;
using System.Data.Common;

namespace SqlOrm.Queries;

public partial class QueryBuilder<T, DbCommand> : IEditable<T>
{

    private readonly IClient _clientConnection;

    public QueryBuilder()
    {
        _clientConnection = new OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;");
    }
    public virtual IEnumerable<T> GetAll()
    {
        string query = $"SELECT * FROM {T.ToString()}";

    }
}

