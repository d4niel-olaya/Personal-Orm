using System;


namespace SqlOrm.Interfaces.Connection;
public interface IConnection
{
    string _state {get;}
    void Open();

    bool IsOpen();

    string State();

    void Close();
}