using SqlOrm.Interfaces.Query;
using System.Collections;
using System.Data.Common;

namespace SqlOrm.Queries;

public partial class QueryBuilder<T, DbCommand> : IEditable<T>
{
    public virtual IEnumerable<T> GetAll()
    {
        
    }
}

