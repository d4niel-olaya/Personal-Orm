using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using SqlOrm.Interfaces.Connection;
using System.Data.SqlClient;

namespace SqlOrm.Interfaces.Query;


internal interface IRead<T>
{
    public IEnumerable<T> GetAll();

    // public T GetOne();
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



internal interface IQuerys<TCommand, TReader, TParameter, TClient> where TCommand : DbCommand 
    where TReader : DbDataReader where TParameter : DbParameter
{
    void Read(string query);
 
    void Insert(string query);
}


internal interface IQueryClient : IQuerys<SqlCommand, SqlDataReader, SqlParameter, IClient>{}