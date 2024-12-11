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
                textBox4.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Pages"].Value).ToString("F2");
                textBox7.Text = Convert.ToDouble(dataGridView1.CurrentRow.Cells["Rating"].Value).ToString("F2");
                textBox6.Text = dataGridView1.CurrentRow.Cells["Publisher"].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells["Genres"].Value.ToString();
                textBox5.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Price"].Value).ToString("F2");
                //dateTimePicker1.Value = dataGridView1.CurrentRow.Cells["LastModified"].Value;
            }

        }
    }
}
