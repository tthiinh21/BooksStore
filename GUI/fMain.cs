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
    public partial class fMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string userRole;
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public fMain(string role)
        {
            InitializeComponent();
            userRole = role;
            roles(userRole);
        }

        void roles(string role)
        {
            if (userRole != "Admin")
            {
                nhânViênToolStripMenuItem.Visible = false;
            }
        }

        private void AddForms(Form f)
        {
            this.grb_content.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None; //bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grb_content.Controls.Add(f);
            f.Show();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptb_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptb_minisize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptb_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ptb_minisize_Paint(object sender, PaintEventArgs e)
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

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fBooks();

            AddForms(f);
        }
    }
}
