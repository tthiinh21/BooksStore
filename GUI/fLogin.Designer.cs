namespace QL_TruongHoc.GUI.Đăng_nhập
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            pn_left = new Panel();
            ptb_maxisize = new Panel();
            ptb_close = new Panel();
            lb_logo = new Label();
            grb_content = new GroupBox();
            btn_thoat = new Button();
            btn_dangnhap = new Button();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            lb_matkhau = new Label();
            lb_taikhoan = new Label();
            lb_dangnhap = new Label();
            pn_right = new Panel();
            ptb_logo = new Panel();
            pn_top = new Panel();
            pn_bottom = new Panel();
            ptb_minisize = new Panel();
            grb_content.SuspendLayout();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // pn_left
            // 
            pn_left.BackColor = Color.LightSlateGray;
            pn_left.Dock = DockStyle.Left;
            pn_left.Location = new Point(0, 37);
            pn_left.Name = "pn_left";
            pn_left.Size = new Size(15, 212);
            pn_left.TabIndex = 19;
            // 
            // ptb_maxisize
            // 
            ptb_maxisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_maxisize.BackColor = Color.LightCyan;
            ptb_maxisize.Cursor = Cursors.Hand;
            ptb_maxisize.Location = new Point(475, 2);
            ptb_maxisize.Name = "ptb_maxisize";
            ptb_maxisize.Size = new Size(30, 31);
            ptb_maxisize.TabIndex = 3;
            ptb_maxisize.Click += ptb_maxisize_Click;
            ptb_maxisize.Paint += ptb_maxisize_Paint;
            // 
            // ptb_close
            // 
            ptb_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_close.BackColor = Color.LightCyan;
            ptb_close.Cursor = Cursors.Hand;
            ptb_close.Location = new Point(509, 2);
            ptb_close.Name = "ptb_close";
            ptb_close.Size = new Size(33, 31);
            ptb_close.TabIndex = 2;
            ptb_close.Click += ptb_close_Click;
            ptb_close.Paint += ptb_close_Paint;
            // 
            // lb_logo
            // 
            lb_logo.AutoSize = true;
            lb_logo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lb_logo.ForeColor = Color.White;
            lb_logo.Location = new Point(45, 10);
            lb_logo.Name = "lb_logo";
            lb_logo.Size = new Size(179, 18);
            lb_logo.TabIndex = 1;
            lb_logo.Text = "Quản lý cửa hàng sách";
            // 
            // grb_content
            // 
            grb_content.BackColor = Color.LightSlateGray;
            grb_content.Controls.Add(btn_thoat);
            grb_content.Controls.Add(btn_dangnhap);
            grb_content.Controls.Add(txt_matkhau);
            grb_content.Controls.Add(txt_taikhoan);
            grb_content.Controls.Add(lb_matkhau);
            grb_content.Controls.Add(lb_taikhoan);
            grb_content.Controls.Add(lb_dangnhap);
            grb_content.Dock = DockStyle.Fill;
            grb_content.ForeColor = Color.Coral;
            grb_content.Location = new Point(0, 37);
            grb_content.Name = "grb_content";
            grb_content.Size = new Size(533, 212);
            grb_content.TabIndex = 21;
            grb_content.TabStop = false;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.LightSlateGray;
            btn_thoat.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold);
            btn_thoat.ForeColor = Color.White;
            btn_thoat.Location = new Point(287, 160);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(139, 34);
            btn_thoat.TabIndex = 9;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.LightSlateGray;
            btn_dangnhap.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold);
            btn_dangnhap.ForeColor = Color.White;
            btn_dangnhap.Location = new Point(117, 160);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(139, 34);
            btn_dangnhap.TabIndex = 8;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += button1_Click;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Font = new Font("Microsoft Sans Serif", 8.5F);
            txt_matkhau.Location = new Point(189, 114);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(259, 24);
            txt_matkhau.TabIndex = 7;
            txt_matkhau.Text = "admin123";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Font = new Font("Microsoft Sans Serif", 8.5F);
            txt_taikhoan.Location = new Point(189, 70);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(259, 24);
            txt_taikhoan.TabIndex = 6;
            txt_taikhoan.Text = "admin2@gmail.com";
            // 
            // lb_matkhau
            // 
            lb_matkhau.AutoSize = true;
            lb_matkhau.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold);
            lb_matkhau.ForeColor = Color.White;
            lb_matkhau.Location = new Point(53, 117);
            lb_matkhau.Name = "lb_matkhau";
            lb_matkhau.Size = new Size(82, 18);
            lb_matkhau.TabIndex = 5;
            lb_matkhau.Text = "Mật khẩu:";
            // 
            // lb_taikhoan
            // 
            lb_taikhoan.AutoSize = true;
            lb_taikhoan.Font = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold);
            lb_taikhoan.ForeColor = Color.White;
            lb_taikhoan.Location = new Point(53, 71);
            lb_taikhoan.Name = "lb_taikhoan";
            lb_taikhoan.Size = new Size(87, 18);
            lb_taikhoan.TabIndex = 4;
            lb_taikhoan.Text = "Tài khoản:";
            // 
            // lb_dangnhap
            // 
            lb_dangnhap.AutoSize = true;
            lb_dangnhap.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lb_dangnhap.ForeColor = Color.White;
            lb_dangnhap.Location = new Point(209, 20);
            lb_dangnhap.Name = "lb_dangnhap";
            lb_dangnhap.Size = new Size(153, 26);
            lb_dangnhap.TabIndex = 0;
            lb_dangnhap.Text = "ĐĂNG NHẬP";
            // 
            // pn_right
            // 
            pn_right.BackColor = Color.LightSlateGray;
            pn_right.Dock = DockStyle.Right;
            pn_right.Location = new Point(533, 37);
            pn_right.Name = "pn_right";
            pn_right.Size = new Size(15, 212);
            pn_right.TabIndex = 20;
            // 
            // ptb_logo
            // 
            ptb_logo.BackColor = Color.LightCyan;
            ptb_logo.Location = new Point(4, 2);
            ptb_logo.Name = "ptb_logo";
            ptb_logo.Size = new Size(30, 31);
            ptb_logo.TabIndex = 0;
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.LightSlateGray;
            pn_top.Controls.Add(ptb_maxisize);
            pn_top.Controls.Add(ptb_close);
            pn_top.Controls.Add(ptb_minisize);
            pn_top.Controls.Add(lb_logo);
            pn_top.Controls.Add(ptb_logo);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(548, 37);
            pn_top.TabIndex = 17;
            pn_top.MouseDown += pn_top_MouseDown;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.LightSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 249);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(548, 37);
            pn_bottom.TabIndex = 18;
            // 
            // ptb_minisize
            // 
            ptb_minisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_minisize.BackColor = Color.LightCyan;
            ptb_minisize.BackgroundImage = (Image)resources.GetObject("ptb_minisize.BackgroundImage");
            ptb_minisize.Cursor = Cursors.Hand;
            ptb_minisize.Location = new Point(440, 2);
            ptb_minisize.Name = "ptb_minisize";
            ptb_minisize.Size = new Size(33, 31);
            ptb_minisize.TabIndex = 1;
            ptb_minisize.Click += ptb_minisize_Click;
            // 
            // fDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 286);
            Controls.Add(pn_left);
            Controls.Add(grb_content);
            Controls.Add(pn_right);
            Controls.Add(pn_top);
            Controls.Add(pn_bottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fDangNhap";
            Text = "fDangNhap";
            grb_content.ResumeLayout(false);
            grb_content.PerformLayout();
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_left;
        private Panel ptb_maxisize;
        private Panel ptb_close;
        private Label lb_logo;
        private GroupBox grb_content;
        private Panel pn_right;
        private Panel ptb_logo;
        private Panel pn_top;
        private Panel pn_bottom;
        private Label lb_dangnhap;
        private Label lb_matkhau;
        private Label lb_taikhoan;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private Button btn_dangnhap;
        private Button btn_thoat;
        private Panel ptb_minisize;
    }
}