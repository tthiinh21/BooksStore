using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    internal class Pay
    {
        [BsonElement("method_pay")]
        public String method_pay { get; set; }

        [BsonElement("status")]
        public String status { get; set; }
    }
}
