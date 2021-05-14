using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadconnectionstring()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadconnectionstring()))
            {
                cnn.Execute("insert into Person (FirstName,LastName) values (@FirstName, @LastName)", person);
            }
        }

        private static string loadconnectionstring(string id = "default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
