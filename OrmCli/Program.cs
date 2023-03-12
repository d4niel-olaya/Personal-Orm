using SqlOrm;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(SqlOrm.Class1.Db());
var orm = new SqlOrm.Connection.OrmConnection("Server=Localhost\\SQLEXPRESS; Database=StudyApp; Trusted_Connection=True;");
orm.Open();
