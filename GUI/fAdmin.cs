using MongoDB.Bson;
using MongoDB.Driver;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TruongHoc.GUI
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Admin>("admin");
                var admin = collection.Find(FilterDefinition<Admin>.Empty).ToList();
                dataGridView1.DataSource = admin.Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    Email = d.Email,
                    Password = d.Password,
                    Phone = d.Phone,
                    Address = d.Address,
                    Roles = d.Roles
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
                textBox2.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Roles"].Value.ToString();
                //dateTimePicker1.Value = dataGridView1.CurrentRow.Cells["LastModified"].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Name");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Email");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Chưa nhập Password");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Phone");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Address");
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Chưa nhập Roles");
            }
            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Admin>("admin");

                var newAdmin = new Admin
                {
                    Name = textBox2.Text,
                    Email = textBox3.Text,
                    Password = textBox4.Text,
                    Phone = textBox7.Text,
                    Address = textBox6.Text,
                    Roles = textBox5.Text,
                };

                collection.InsertOne(newAdmin);
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadData(); //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa nhập Name");
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Chưa nhập Email");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Chưa nhập Password");
            }
            else if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Chưa nhập Phone");
            }
            else if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Chưa nhập Address");
            }
            else if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Chưa nhập Roles");
            }
            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Admin>("admin");

                var filter = Builders<Admin>.Filter.Eq(d => d.Id, textBox1.Text);
                var update = Builders<Admin>.Update
                    .Set(d => d.Name, textBox2.Text)
                    .Set(d => d.Email, textBox3.Text)
                    .Set(d => d.Password, textBox4.Text)
                    .Set(d => d.Phone, textBox7.Text)
                    .Set(d => d.Address, textBox6.Text)
                    .Set(d => d.Roles, textBox5.Text)
                    ;

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
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Admin>("admin");

                // Tạo bộ lọc dựa trên ID sản phẩm
                var filter = Builders<Admin>.Filter.Eq(d => d.Id, textBox1.Text);

                // Thực hiện xóa
                var result = collection.DeleteOne(filter);

                // Kiểm tra kết quả xóa
                if (result.DeletedCount > 0)
                {
                    LoadData(); // Tải lại dữ liệu để cập nhật DataGridView
                    MessageBox.Show("Xóa nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xóa.");
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
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Admin>("admin");

                // Tạo bộ lọc tìm kiếm theo Id hoặc Title
                var filter = Builders<Admin>.Filter.Or(
                    //Builders<Books>.Filter.Eq(d => d.Id, textBox9.Text), // Tìm kiếm theo Id
                    Builders<Admin>.Filter.Regex(d => d.Name, new BsonRegularExpression(textBox9.Text, "i")), // Tìm kiếm theo Title (không phân biệt hoa thường)
                    Builders<Admin>.Filter.Regex(d => d.Email, new BsonRegularExpression(textBox9.Text, "i"))
                );

                // Tìm kiếm các sản phẩm thỏa mãn điều kiện
                var products = collection.Find(filter).ToList();

                // Hiển thị kết quả lên DataGridView
                dataGridView1.DataSource = products.Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    Email = d.Email,
                    Password = d.Password,
                    Phone = d.Phone,
                    Address = d.Address,
                    Roles = d.Roles
                }).ToList();

                if (products.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
