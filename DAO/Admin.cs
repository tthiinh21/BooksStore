using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    public class Admin
    {
        [BsonId] // Ánh xạ trường _id
        [BsonRepresentation(BsonType.ObjectId)] // Chỉ định kiểu ObjectId
        public string Id { get; set; }

        [BsonElement("email")] // Tên trường trong MongoDB
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("roles")]
        public string Roles { get; set; }
    }
}
