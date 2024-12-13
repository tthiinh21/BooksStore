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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TruongHoc.GUI
{
    public partial class fOrder : Form
    {
        public fOrder()
        {
            InitializeComponent();
            LoadData();
            //printListOrder();
        }

        private void LoadData()
        {
            try
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");
                var orders = collection.Find(FilterDefinition<Orders>.Empty).ToList();
                dataGridView1.DataSource = orders.Select(d => new
                {
                    Id = d.Id,
                    //OrderCode = d.Order_code,
                    //Customer = d.Customer,
                    Total = d.Total,
                    Shipping = d.Shipping,
                    Order_date = d.Order_date,
                    ListProduct = d.ListProduct,
                    Pay = d.payment,
                    Note = d.Note
                }).ToList();

                List<Pay> listPay = new List<Pay>()
                {
                    new Pay { method_pay = "ATM" , status = "success" },
                    new Pay { method_pay = "Credit Card" , status = "success" },
                    new Pay { method_pay = "Cash On Delivery" , status = "success" },
                };

                ccb_pay.DataSource = listPay;
                ccb_pay.DisplayMember = "method_pay";
                ccb_pay.ValueMember = "method_pay";

                var collectionCus = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");
                var customers = collectionCus.Find(FilterDefinition<Customers>.Empty).ToList();

                ccb_customer_search.DataSource = customers;
                ccb_customer_search.DisplayMember = "Name";
                ccb_customer_search.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void printListOrder()
        {
            var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");
            List<Orders> orders = collection.Find(FilterDefinition<Orders>.Empty).ToList();
            foreach (Orders o in orders)
            {
                MessageBox.Show(o.ListProduct[0].productName.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txt_order_code.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txt_order_date.Text = dataGridView1.CurrentRow.Cells["Order_date"].Value.ToString();
                txt_order_total.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Total"].Value).ToString();
                txt_note.Text = dataGridView1.CurrentRow.Cells["Note"].Value.ToString();
                txt_order_shipping.Text = dataGridView1.CurrentRow.Cells["Shipping"].Value.ToString();
                //txt.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Rating"].Value).ToString("F2");
                //textBox10.Text = dataGridView1.CurrentRow.Cells["Genres"].Value.ToString();
                //List<ProductInOrder> productInOrders = dataGridView1.CurrentRow.Cells["ListProduct"].Value;




                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");
                List<Orders> orders = collection.Find(FilterDefinition<Orders>.Empty).ToList();

                //Danh sach SP
                LoadDataProductOrder(orders[dataGridView1.CurrentRow.Index].ListProduct);

                //Ten KH
                txt_order_customer.Text = findCustomerOrderById(orders[dataGridView1.CurrentRow.Index].Customer).Name;

                //Phuong thuc thanh toan 
                ccb_pay.Text = orders[dataGridView1.CurrentRow.Index].payment[0].method_pay;
            }

        }

        private void LoadDataProductOrder(List<ProductInOrder> productInOrders)
        {
            try
            {
                dataGridView2.DataSource = productInOrders.Select(d => new
                {
                    ProductName = d.productName,
                    Quantity = d.quantity,
                    Price = d.price
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private Customers findCustomerOrderById(String id)
        {
            var collection = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");
            var filter = Builders<Customers>.Filter.Eq(customer => customer.Id, id);
            Customers customer = collection.Find(filter).FirstOrDefault();
            return customer;
        }

        private void btn_add_order_Click(object sender, EventArgs e)
        {
            var f = new fAddNewOrder();
            f.Show();
        }

        private void btn_edit_order_Click(object sender, EventArgs e)
        {
            string datePattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-\d{4}$";
            if (string.IsNullOrEmpty(txt_order_shipping.Text))
            {
                MessageBox.Show("Chưa nhập Shipping");
            }
            else if (string.IsNullOrEmpty(txt_order_date.Text))
            {
                MessageBox.Show("Chưa nhập Ngày");
            }
            else if (!Regex.IsMatch(txt_order_date.Text, datePattern))
            {
                MessageBox.Show("Vui lòng nhập theo định dạng dd-mm-yyyy");
            }
            else
            {

                List<Pay> listPay = new List<Pay>();
                Pay p = new Pay()
                {
                    method_pay = ccb_pay.SelectedValue.ToString(),
                    status = "success"
                };
                listPay.Add(p);

                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");

                var filter = Builders<Orders>.Filter.Eq(d => d.Id, txt_order_code.Text);
                var update = Builders<Orders>.Update
                    .Set(d => d.Shipping, txt_order_shipping.Text)
                    .Set(d => d.Note, txt_note.Text)
                    .Set(d => d.Order_date, txt_order_date.Text)
                    .Set(d => d.payment, listPay);
                //.Set(d => d.Price, Convert.ToInt32(textBox5.Text))
                //.Set(d => d.Publisher, textBox6.Text)
                //.Set(d => d.Rating, Convert.ToDouble(textBox7.Text))
                //.Set(d => d.Genres, genresList)
                //.Set(d => d.LastModified, DateTime.Now);

                collection.UpdateOne(filter, update);
                MessageBox.Show("Cập nhật đơn thành công thành công!");
                LoadData();
            }
        }

        private void btn_delete_order_Click(object sender, EventArgs e)
        {
            try
            {
                // Kết nối tới collection "products" trong MongoDB
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");

                // Tạo bộ lọc dựa trên ID sản phẩm
                var filter = Builders<Orders>.Filter.Eq(d => d.Id, txt_order_code.Text);

                // Thực hiện xóa
                var result = collection.DeleteOne(filter);

                // Kiểm tra kết quả xóa
                if (result.DeletedCount > 0)
                {
                    LoadData(); // Tải lại dữ liệu để cập nhật DataGridView
                    MessageBox.Show("Xóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa đơn: " + ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");
                var filter = Builders<Orders>.Filter.Eq(o => o.Customer, ccb_customer_search.SelectedValue.ToString());

                var orders = collection.Find(filter).ToList();

                // Hiển thị kết quả lên DataGridView
                dataGridView1.DataSource = orders.Select(d => new
                {
                    Id = d.Id,
                    //OrderCode = d.Order_code,
                    //Customer = d.Customer,
                    Total = d.Total,
                    Shipping = d.Shipping,
                    Order_date = d.Order_date,
                    ListProduct = d.ListProduct,
                    Pay = d.payment,
                    Note = d.Note
                }).ToList();

                if (orders.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
}
    }
}
