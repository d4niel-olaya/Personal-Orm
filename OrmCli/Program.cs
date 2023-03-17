using SqlOrm;
using SqlOrm.Queries;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SqlOrm.Class1.Db());
var lector = new QueryBuilder();
Console.WriteLine(lector.GetAll());



