using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace TestMongoDB
{
    public class MongoDB
    {

        public MongoDB()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://NovaFoxy:<Kyuubi99>@maincluster.jtr1q.mongodb.net/?retryWrites=true&w=majority");

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList);
        }
    }
}
