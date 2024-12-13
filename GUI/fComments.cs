using QL_TruongHoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace QL_TruongHoc.GUI
{

    public partial class fComments : Form
    {
        private string BookId;
        public fComments(string bookId)
        {
            InitializeComponent();
            BookId = bookId;
            LoadComments();
        }

        private void LoadComments()
        {
            var collection = ConnectToDatabase.GetDatabase().GetCollection<Comments>("comments");

            // Tìm bình luận liên quan đến _id của sách
            var comments = collection.Find(d => d.BookId == new MongoDB.Bson.ObjectId(BookId)).ToList();

            listView1.Items.Clear(); // Xóa các mục cũ trong ListView

            foreach (var comment in comments)
            {
                // Tạo một ListViewItem
                var item = new ListViewItem(comment.Id.ToString());
                item.SubItems.Add(comment.NameId.ToString());
                item.SubItems.Add(comment.Comment);
                item.SubItems.Add(comment.Comment_Number_Liked.ToString());
                item.SubItems.Add(comment.Comment_Number_Disliked.ToString());
                item.SubItems.Add(comment.Comment_Date.ToString("dd/MM/yyyy HH:mm:ss"));

                // Thêm mục vào ListView
                listView1.Items.Add(item);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
