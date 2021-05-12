namespace Gifter.Persistance.Dapper.SQLite.Config
{
    class ZEsGifterDBContext : IZEsGifterDBContext
    {

        private string _connectionString;
        public ZEsGifterDBContext(string connectionString)
        {
            _connectionString = connectionString
        }
        public string ConnectionString { get { return _connectionString; } }
    }
}
