

using System;
using SqlOrm.Interfaces.Query;
using SqlOrm.Interfaces.Connection;
using SqlOrm.Command;
namespace SqlOrm.Crud;



    public interface ICrud<T> : IRead<T>{}

    public class SqlCrud<T>
    {

        private readonly IClient _client;

        public SqlCrud(IClient client)
        {
            _client = client;
        }
        public IEnumerable<T> GetAll(string query)
        {
            using(_client.getClient())
            {   
                var comando = new SqlOrmCommand(query, _client);
                var list = new List<T>();
                _client.Open(); 
                var reader = comando.getReader();
                var count = 0;
                while(reader.Read())
                {
                    list.Add(reader.GetFieldValue<T>(count));
                    count++;
                }
                _client.Close();
                return list;
            }
        }   
    }
