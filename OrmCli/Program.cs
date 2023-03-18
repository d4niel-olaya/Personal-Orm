using SqlOrm;
using SqlOrm.Queries;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SqlOrm.Class1.Db());
var query = new QueryBuilder();
query.GetAll();



