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
using MongoDB.Driver;
using MongoDB.Bson;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic.ApplicationServices;

namespace QL_TruongHoc.GUI.Đăng_nhập
{
    public partial class fLogin : Form
    {
        private IMongoDatabase database;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public fLogin()
        {
            InitializeComponent();
            database = ConnectToDatabase.GetDatabase();
        }

        

        private void ptb_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptb_maxisize_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptb_close_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txt_taikhoan.Text.Trim();
            string passWord = txt_matkhau.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                var collection = database.GetCollection<Admin>("admin");
                var filter = Builders<Admin>.Filter.And(
                    Builders<Admin>.Filter.Eq(u => u.Email, userName),
                    Builders<Admin>.Filter.Eq(u => u.Password, passWord)
                );

                var admin = collection.Find(filter).FirstOrDefault();

                if (admin != null)
                {
                    MessageBox.Show($"Chào mừng, {admin.Name}!", "Đăng nhập thành công");
                    fMain f = new fMain(admin.Roles);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối tới cơ sở dữ liệu: " + ex.Message);
            }
            /*if (Login(userName, passWord))
            {
                TaiKhoan loginTaiKhoan = TaiKhoanDAO.Instance.GetTaiKhoanByMa_NhanVien(userName);
                fMain f = new fMain(loginTaiKhoan);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mã nhân viên hoặc mật khẩu!");
            }*/
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptb_maxisize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                /*pictureBox2.Image = Properties.Resources.res;*/

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                /*pictureBox2.Image = Properties.Resources.maxi;*/
            }
        }
    }
}
