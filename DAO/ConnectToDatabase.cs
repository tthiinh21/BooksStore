using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace QL_TruongHoc.DAO
{
    public class ConnectToDatabase
    {
        private static IMongoDatabase database;
        private static MongoClient client;

        // Chuỗi kết nối MongoDB
        private static readonly string connectionString = "mongodb://localhost:27017"; // Thay bằng chuỗi kết nối của bạn
        private static readonly string databaseName = "bookstore"; // Tên database của bạn

        // Phương thức khởi tạo kết nối MongoDB
        public static IMongoDatabase GetDatabase()
        {
            if (database == null)
            {
                try
                {
                    client = new MongoClient(connectionString);
                    database = client.GetDatabase(databaseName);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi kết nối tới MongoDB: " + ex.Message);
                }
            }
            return database;
        }
    }
}
