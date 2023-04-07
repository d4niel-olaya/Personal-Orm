using SqlOrm.Connection;
using SqlOrm.Queries;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SqlOrm.Class1.Db());
var query = new QueryBuilder();
query.GetAll();
var fields = new List<int>(){0};
var result = new SqlOrm.Crud.SqlCrud<int>(new OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;"));

var list = result.GetAll("SELECT 2+2 AS number");
foreach(var i in list)
{
    Console.WriteLine(i);
}





