
using SqlOrm.Interfaces.Connection;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
namespace SqlOrm.Connection;

public class OrmConnection : IClient
{
    private readonly string _state;

    private readonly SqlConnection _client;

    public SqlConnection getClient()
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
        if(ConnectionState.Open = 1)
        {
            return true;
        }
        return false;
    }

    public virtual string State()
    {
        return _client.State.ToString();
    }

}


