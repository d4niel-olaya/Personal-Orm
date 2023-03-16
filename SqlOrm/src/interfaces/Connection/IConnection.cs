using System;
using System.Data.Common;

namespace SqlOrm.Interfaces.Connection;
public interface IConnection<T> where T : DbConnection
{

    T getClient();
    void Open();

    bool IsOpen();

    string State();

    void Close();
}