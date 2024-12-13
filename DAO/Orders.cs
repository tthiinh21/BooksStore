using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    internal class Orders
    {
        [BsonId] // Ánh xạ trường _id
        [BsonRepresentation(BsonType.ObjectId)] // Chỉ định kiểu ObjectId
        public string Id { get; set; }

        [BsonElement("order_code")]
        public string Order_code { get; set; }

        [BsonElement("customer")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Customer { get; set; }

        [BsonElement("shipping")]
        public string Shipping { get; set; }

        [BsonElement("total")]
        public int Total { get; set; }

        [BsonElement("order_date")]
        public String Order_date { get; set; }

        [BsonElement("product")]
        public List<ProductInOrder> ListProduct { get; set; }

        [BsonElement("pay")]
        public List<Pay> payment { get; set; }

        [BsonElement("note")]
        public string Note { get; set; }
    }
}
