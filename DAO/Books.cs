using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace QL_TruongHoc.DAO
{
    public class Books
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("author")]
        public string Author { get; set; }
        [BsonElement("pages")]
        public int Pages { get; set; }
        [BsonElement("genres")]
        public List<string> Genres { get; set; }
        [BsonElement("rating")]
        public double Rating { get; set; }

        [BsonElement("publisher")]
        public string Publisher { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("lastModified")]
        public DateTime LastModified { get; set; }
    }
}
