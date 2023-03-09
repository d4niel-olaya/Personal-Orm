
using SqlOrm.Interfaces.Connection;
namespace SqlOrm.Connection;

public class OrmConnection : IConnection
{
    private readonly string _state;


    public virtual void Open()
    {

    }

    public virtual void Close()
    {

    }

    public virtual bool IsOpen()
    {
        return true;
    }

    public virtual string State()
    {
        return "Up";
    }

}


