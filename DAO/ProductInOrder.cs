using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    internal class ProductInOrder
    {
        [BsonElement("name_p")]
        public String productName;

        [BsonElement("qty_p")]
        public int quantity;

        [BsonElement("price_p")]
        public int price;
    }
}
