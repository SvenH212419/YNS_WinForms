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
            try
            {
                var dbClient = new MongoClient("mongodb+srv://NovaFoxy:Kyuubi99@maincluster.jtr1q.mongodb.net/?retryWrites=true&w=majority");
                IMongoDatabase db = dbClient.GetDatabase("YNS");
                var YNS = db.GetCollection<BsonDocument>("Parameters");

                var documents = YNS.Find(new BsonDocument()).ToList();

                foreach (BsonDocument doc in documents)
                {
                    MessageBox.Show(doc.ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yo");
            }
        }
    }
}
