using MongoDB.Bson;
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
using MongoDB.Bson;
using MongoDB.Driver;
using DnsClient;
using System.Diagnostics;
using System.Security.Policy;
using Microsoft.VisualBasic.Devices;

namespace QL_TruongHoc.GUI
{
    public partial class fBooks : Form
    {
        public fBooks()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");
                var books = collection.Find(FilterDefinition<Books>.Empty).ToList();
                dataGridView1.DataSource = books.Select(d => new
                {
                    Id = d.Id,
                    Title = d.Title,
                    Author = d.Author,
                    Pages = d.Pages,
                    Genres = string.Join(", ", d.Genres),
                    Rating = d.Rating,
                    Publisher = d.Publisher,
                    Price = d.Price,
                    LastModified = d.LastModified.ToString("dd/MM/yyyy HH:mm:ss")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Author"].Value.ToString();
                textBox4.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Pages"].Value).ToString();
                textBox5.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Price"].Value).ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["Publisher"].Value.ToString();
                textBox7.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Rating"].Value).ToString("F2");
                textBox10.Text = dataGridView1.CurrentRow.Cells["Genres"].Value.ToString();

                //dateTimePicker1.Value = dataGridView1.CurrentRow.Cells["LastModified"].Value;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Title");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Author");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Chưa nhập Pages");
            }
            else if (string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("Chưa nhập Genres");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Rating");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Publisher");
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Chưa nhập Price");
            }
            else if (!int.TryParse(textBox4.Text, out int _))
            {
                MessageBox.Show("Pages nhập sai kiểu dữ liệu");
            }
            else if (!double.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Rating nhập sai kiểu dữ liệu");
            }
            else if (!int.TryParse(textBox5.Text, out int _))
            {
                MessageBox.Show("Price nhập sai kiểu dữ liệu");
            }
            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");

                string genresInput = textBox10.Text.Trim();
                List<string> genresList = genresInput
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(g => g.Trim())
                    .ToList();

                var newBooks = new Books
                {
                    Title = textBox2.Text,
                    Author = textBox3.Text,
                    Pages = Convert.ToInt32(textBox4.Text),
                    Price = Convert.ToInt32(textBox5.Text),
                    Publisher = textBox6.Text,
                    Rating = Convert.ToDouble(textBox7.Text),
                    Genres = genresList,
                    LastModified = DateTime.Now
                };

                collection.InsertOne(newBooks);
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData(); //
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Title");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Author");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Chưa nhập Pages");
            }
            else if (string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("Chưa nhập Genres");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Rating");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Publisher");
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Chưa nhập Price");
            }
            else if (!int.TryParse(textBox4.Text, out int _))
            {
                MessageBox.Show("Pages nhập sai kiểu dữ liệu");
            }
            else if (!double.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Rating nhập sai kiểu dữ liệu");
            }
            else if (!int.TryParse(textBox5.Text, out int _))
            {
                MessageBox.Show("Price nhập sai kiểu dữ liệu");
            }
            else
            {
                string genresInput = textBox10.Text.Trim();
                List<string> genresList = genresInput
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(g => g.Trim())
                    .ToList();
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");

                var filter = Builders<Books>.Filter.Eq(d => d.Id, textBox1.Text);
                var update = Builders<Books>.Update
                    .Set(d => d.Title, textBox2.Text)
                    .Set(d => d.Author, textBox3.Text)
                    .Set(d => d.Pages, Convert.ToInt32(textBox4.Text))
                    .Set(d => d.Price, Convert.ToInt32(textBox5.Text))
                    .Set(d => d.Publisher, textBox6.Text)
                    .Set(d => d.Rating, Convert.ToDouble(textBox7.Text))
                    .Set(d => d.Genres, genresList)
                    .Set(d => d.LastModified, DateTime.Now);

                collection.UpdateOne(filter, update);
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới collection "products" trong MongoDB
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");

                // Tạo bộ lọc dựa trên ID sản phẩm
                var filter = Builders<Books>.Filter.Eq(d => d.Id, textBox1.Text);

                // Thực hiện xóa
                var result = collection.DeleteOne(filter);

                // Kiểm tra kết quả xóa
                if (result.DeletedCount > 0)
                {
                    LoadData(); // Tải lại dữ liệu để cập nhật DataGridView
                    MessageBox.Show("Xóa sản phẩm thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới collection "products"
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");

                // Tạo bộ lọc tìm kiếm theo Id hoặc Title
                var filter = Builders<Books>.Filter.Or(
                    //Builders<Books>.Filter.Eq(d => d.Id, textBox9.Text), // Tìm kiếm theo Id
                    Builders<Books>.Filter.Regex(d => d.Title, new BsonRegularExpression(textBox9.Text, "i")), // Tìm kiếm theo Title (không phân biệt hoa thường)
                    Builders<Books>.Filter.Regex(d => d.Author, new BsonRegularExpression(textBox9.Text, "i"))
                );

                // Tìm kiếm các sản phẩm thỏa mãn điều kiện
                var products = collection.Find(filter).ToList();

                // Hiển thị kết quả lên DataGridView
                dataGridView1.DataSource = products.Select(d => new
                {
                    Id = d.Id,
                    Title = d.Title,
                    Author = d.Author,
                    Pages = d.Pages,
                    Genres = string.Join(", ", d.Genres),
                    Rating = d.Rating,
                    Publisher = d.Publisher,
                    Price = d.Price,
                    LastModified = d.LastModified.ToString("dd/MM/yyyy HH:mm:ss")
                }).ToList();

                if (products.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào thỏa mãn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
