using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMongoDB
{
    [BsonIgnoreExtraElements]
    internal class Media
    {
        public string Temp { get; set; }
        public string Celsius { get; set; }
        
    }
}
