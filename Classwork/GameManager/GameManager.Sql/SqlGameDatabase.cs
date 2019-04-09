using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Sql
{
    public class SqlGameDatabase : GameDatabase
    {

        public SqlGameDatabase (string connectionString)
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        protected override Game AddCore( Game game )
        {
            NewMethod();

            throw new NotImplementedException();
        }

        private void NewMethod()
        {
            var connection = new SqlConnection(_connectionString);
        }

        protected override void DeleteCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            throw new NotImplementedException();
        }

        protected override Game GetCore( int id )
        {
            throw new NotImplementedException();
        }

        protected override Game UpdateCore( int id, Game newGame )
        {
            throw new NotImplementedException();
        }
    }
}
