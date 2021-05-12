namespace Gifter.Persistance.Dapper.SQLite.Config
{
    public class GifterLemonDBContext : IGifterDBContext
    {
        private string _connectionString;
        public GifterLemonDBContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString
        {

            get
            {
                return _connectionString;
            }

        }
    }
}
