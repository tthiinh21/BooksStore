using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    public class Customers
    {
        [BsonId] // Ánh xạ trường _id
        [BsonRepresentation(BsonType.ObjectId)] // Chỉ định kiểu ObjectId
        public string Id { get; set; }

        [BsonElement("name")] // Tên trường trong MongoDB
        public string Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
    }
}
