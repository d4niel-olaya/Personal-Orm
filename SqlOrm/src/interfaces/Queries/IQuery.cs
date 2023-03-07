using System;
using System.Collections;

namespace SqlOrm.Interfaces.Query;


public interface IRead<T>
{
    public IEnumerable<T> GetAll();

    public T GetOne();
}

public interface IDelete<T>
{
    public T Deleted();
}

public interface IUpdate<T>
{
    public T Update();
}


public interface ICreate<T>
{
    public T Create();
}

public interface ISqlRaw
{
    
}