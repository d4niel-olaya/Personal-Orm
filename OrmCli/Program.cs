using SqlOrm;
using SqlOrm.Queries;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SqlOrm.Class1.Db());
var query = new QueryBuilder();
query.GetAll();
var fields = new List<int>(){0};
var result = QueryUtils<int>.Read("SELECT 1 as Mensaje", "Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;",fields);

foreach(var i in result)
{
    Console.WriteLine(i);
}





