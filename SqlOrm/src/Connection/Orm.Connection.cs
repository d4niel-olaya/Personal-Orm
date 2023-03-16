
using SqlOrm.Interfaces.Connection;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
namespace SqlOrm.Connection;

public class OrmConnection : IClient
{
    private readonly string _state;

    private readonly DbConnection _client;

    public DbConnection getClient()
    {
        return _client;
    }

    public OrmConnection(string strConnection)
    {
        _client = new SqlConnection(strConnection);
    }

    public virtual void Open()
    {
        if(_client.State != ConnectionState.Open)
        {
            _client.Open();
        }
        Console.WriteLine(_client.State);

    }

    public virtual void Close()
    {
        if(_client.State != ConnectionState.Closed)
        {
            _client.Close();
        }
    }

    public virtual bool IsOpen()
    {
        return ConnectionState.Open ? true : false;
    }

    public virtual string State()
    {
        return _client.State.ToString();
    }

}


