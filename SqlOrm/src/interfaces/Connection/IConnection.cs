using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace SqlOrm.Interfaces.Connection;
public interface IConnection<T> where T : DbConnection
{

    T getClient();
    void Open();

    bool IsOpen();

    string State();

    void Close();
}

public interface IClient : IConnection<SqlConnection>{}