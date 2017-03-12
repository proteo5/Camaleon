using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Camaleon.lib
{
    public class Environment
    {
        internal static string conString = ConfigurationManager.AppSettings["MongoServer"];
        
        internal static string dbString = ConfigurationManager.AppSettings["MongoDatabase"];

        internal static MongoClient server = new MongoClient(conString);
        internal static IMongoDatabase database = server.GetDatabase(dbString);

        public static List<string> ListTables()
        {
            var tables = new List<string>();

            var collection = database.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result;
            foreach (var item in collection)
                if (item["name"] != "system.indexes")
                    tables.Add(item["name"].ToString());
            

            return tables;
        }
    }
}
