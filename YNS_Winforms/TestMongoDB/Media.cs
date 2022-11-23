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
        public string Media_cover { get; set; }
        public string Media_title { get; set; }
        public string Media_description { get; set; }
        public string Media_playable { get; set; }
        public string Media_type { get; set; }
        public string Media_category { get; set; }
        public bool Media_check { get; set; }
        public bool Media_fav { get; set; }
    }
}
