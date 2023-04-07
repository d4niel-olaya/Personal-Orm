using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using SqlOrm.Interfaces.Connection;
using System.Data.SqlClient;

namespace SqlOrm.Interfaces.Query;


public interface IRead<T>
{
    public IEnumerable<T> GetAll();

    // public T GetOne();
}

public  interface IDelete<T>
{
    public T Deleted(T entity);
}

public interface IUpdate<T>
{
    public T Update(T entity);
}


public interface ICreate<T>
{
    public T Create(T entity);
}

public interface ISqlRaw
{
    
}



public interface IQuerys<TCommand, TReader, TParameter, TClient, TResult> where TCommand : DbCommand 
    where TReader : DbDataReader where TParameter : DbParameter
{
    TResult Read(string query);
 
    void Insert(string query);
}


public interface IQueryClient : IQuerys<SqlCommand, SqlDataReader, SqlParameter, IClient, IEnumerable<string>>{}