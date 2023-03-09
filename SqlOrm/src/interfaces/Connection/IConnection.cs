using System;


namespace SqlOrm.Interfaces.Connection;
internal interface IConnection
{
    string _state {get;}
    void Open();

    bool IsOpen();

    string State();

    void Close();
}