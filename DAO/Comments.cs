using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TruongHoc.DAO
{
    public class Comments
    {
        [BsonId] // Ánh xạ trường _id
        [BsonRepresentation(BsonType.ObjectId)] // Chỉ định kiểu ObjectId
        public string Id { get; set; }
        [BsonElement("comment")]
        public string Comment{ get; set; }

        [BsonElement("comment_number_liked")]
        public int Comment_Number_Liked { get; set; }
        [BsonElement("comment_number_disliked")]
        public int Comment_Number_Disliked { get; set; }

        [BsonElement("comment_book_id")]
        public ObjectId BookId { get; set; }
        [BsonElement("comment_name_id")]
        public ObjectId NameId { get; set; }

        [BsonElement("comment_date")]
        public DateTime Comment_Date { get; set; }

    }
}
