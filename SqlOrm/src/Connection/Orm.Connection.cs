
using SqlOrm.Interfaces.Connection;
namespace SqlOrm.Connection;

public class OrmConnection : IConnection
{
    private readonly string _state;


    public void Open()
    {

    }

    public void Close()
    {

    }

    public bool IsOpen()
    {
        return true;
    }

    public string State()
    {
        return "Up";
    }

}


