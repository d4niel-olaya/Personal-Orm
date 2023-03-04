using System;


namespace SqlOrm.Connection;
public interface IConnection
{
    void Open();

    bool IsOpen();

    string State();

    void Close();
}