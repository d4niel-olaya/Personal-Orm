using System;
using System.Collections;
using System.Data;
using System.Data.Common;

namespace SqlOrm.Interfaces.Query;


internal interface IRead<T>
{
    public IEnumerable<T> GetAll();

    public T GetOne();
}

internal interface IDelete<T>
{
    public T Deleted();
}

internal interface IUpdate<T>
{
    public T Update();
}


internal interface ICreate<T>
{
    public T Create();
}

internal interface ISqlRaw
{
    
}

internal interface IEditable<T, TCommand> : IUpdate<T>, ICreate<T>, IDelete<T>{}


internal interface IQuerys<TCommand, TReader, TParameter> where TCommand : DbCommand 
    where TReader : DbDataReader where TParameter : DbParameter
{
    void Read();

    void Insert();
}

internal interface IQueryClient : IQuerys<SqlCommand, SqlDataReader, SqlParameter>{}