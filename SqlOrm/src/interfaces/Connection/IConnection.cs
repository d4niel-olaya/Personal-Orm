using System;


namespace SqlOrm.Interfaces.Connection;
public interface IConnection
{
    void Open();

    bool IsOpen();

    string State();

    void Close();
}