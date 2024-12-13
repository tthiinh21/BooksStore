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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_TruongHoc.GUI
{
    public partial class fAddNewOrder : Form
    {
        public fAddNewOrder()
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

                //for(int i =0; i< books.Count(); i++)
                //{
                //    dataGridView1.Rows.Add(false);
                //}

                dataGridView1.DataSource = books.Select(d => new
                {
                    Id = d.Id,
                    Title = d.Title,
                    //Author = d.Author,
                    //Pages = d.Pages,
                    //Genres = string.Join(", ", d.Genres),
                    //Rating = d.Rating,
                    //Publisher = d.Publisher,
                    Price = d.Price,
                    //LastModified = d.LastModified.ToString("dd/MM/yyyy HH:mm:ss")
                }).ToList();



                var collectionCustomer = ConnectToDatabase.GetDatabase().GetCollection<Customers>("customers");
                var customers = collectionCustomer.Find(FilterDefinition<Customers>.Empty).ToList();

                ccb_customers.DataSource = customers;
                ccb_customers.DisplayMember = "Name";
                ccb_customers.ValueMember = "Id";

                List<Pay> listPay = new List<Pay>()
                {
                    new Pay { method_pay = "ATM" , status = "success" },
                    new Pay { method_pay = "Credit Card" , status = "success" },
                    new Pay { method_pay = "Cash On Delivery" , status = "success" },
                };

                ccb_payment.DataSource = listPay;
                ccb_payment.DisplayMember = "method_pay";
                ccb_payment.ValueMember = "method_pay";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_create_order_Click(object sender, EventArgs e)
        {
            List<ProductInOrder> productInOrder = checkProductForOrder(dataGridView1);
            if (string.IsNullOrEmpty(txt_order_shipping.Text))
            {
                MessageBox.Show("Chưa nhập Shipping");
            } else if(productInOrder.Count() == 0)
            {
                MessageBox.Show("Chưa nhập Hàng cần mua");
            }
            else
            {
                var collection = ConnectToDatabase.GetDatabase().GetCollection<Orders>("orders");

                //string genresInput = textBox10.Text.Trim();
                List<Pay> payList = new List<Pay>()
                {
                    new Pay{ method_pay = ccb_payment.SelectedValue.ToString(), status = "success"}
                };
                var newOrder = new Orders
                {

                    Customer = ccb_customers.SelectedValue.ToString(),
                    Shipping = txt_order_shipping.Text,
                    Order_code = "123455",
                    //Total = Convert.ToInt32(txt_order_total.Text),
                    Total = checkTotal(productInOrder),
                    Note = txt_note.Text,
                    payment = payList,
                    ListProduct = productInOrder,
                    Order_date = DateTime.Now.ToString("dd-MM-yyyy")
                };
                collection.InsertOne(newOrder);
                MessageBox.Show("Create Order Success!");
                LoadData();
                Close();//
            }
        }

        private List<ProductInOrder> checkProductForOrder(DataGridView e)
        {
            var collection = ConnectToDatabase.GetDatabase().GetCollection<Books>("books");
            List<Books> books = collection.Find(FilterDefinition<Books>.Empty).ToList();
            List<ProductInOrder> listProduct = new List<ProductInOrder>();

            for (int i = 0; i < books.Count(); i++)
            {
                if (Convert.ToBoolean(e.Rows[i].Cells[0].Value))
                {
                    ProductInOrder p = new ProductInOrder();
                    if (e.Rows[i].Cells[1].Value == null)
                    {
                        p.quantity = 1;
                    }
                    else
                    {
                        p.quantity = Convert.ToInt32(e.Rows[i].Cells[1].Value);
                    }
                    
                    p.productName = e.Rows[i].Cells[3].Value.ToString();
                    p.price = Convert.ToInt32(e.Rows[i].Cells[4].Value);
                    listProduct.Add(p);
                }
            }

            return listProduct;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private int checkTotal(List<ProductInOrder> list)
        {
            int sum = 0;

            for(int i = 0; i < list.Count(); i++)
            {
                sum += list[i].price * list[i].quantity;
            }

            return sum;
        }
    }
}
