namespace QL_TruongHoc.GUI
{
    partial class fMain
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
            pn_top = new Panel();
            ptb_close = new Panel();
            ptb_maxisize = new Panel();
            ptb_minisize = new Panel();
            lb_logo = new Label();
            ptb_logo = new Panel();
            ptb = new PictureBox();
            pn_bottom = new Panel();
            pn_left = new Panel();
            pn_right = new Panel();
            ms_content = new MenuStrip();
            sáchToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            grb_content = new GroupBox();
            pn_top.SuspendLayout();
            ptb_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb).BeginInit();
            ms_content.SuspendLayout();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.LightSlateGray;
            pn_top.Controls.Add(ptb_close);
            pn_top.Controls.Add(ptb_maxisize);
            pn_top.Controls.Add(ptb_minisize);
            pn_top.Controls.Add(lb_logo);
            pn_top.Controls.Add(ptb_logo);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(1340, 37);
            pn_top.TabIndex = 5;
            pn_top.MouseDown += pn_top_MouseDown;
            // 
            // ptb_close
            // 
            ptb_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_close.BackColor = Color.LightCyan;
            ptb_close.Cursor = Cursors.Hand;
            ptb_close.Location = new Point(1303, 2);
            ptb_close.Name = "ptb_close";
            ptb_close.Size = new Size(33, 31);
            ptb_close.TabIndex = 2;
            ptb_close.Click += ptb_close_Click;
            // 
            // ptb_maxisize
            // 
            ptb_maxisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_maxisize.BackColor = Color.LightCyan;
            ptb_maxisize.Cursor = Cursors.Hand;
            ptb_maxisize.Location = new Point(1268, 2);
            ptb_maxisize.Name = "ptb_maxisize";
            ptb_maxisize.Size = new Size(33, 31);
            ptb_maxisize.TabIndex = 3;
            ptb_maxisize.Click += ptb_maxisize_Click;
            // 
            // ptb_minisize
            // 
            ptb_minisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_minisize.BackColor = Color.LightCyan;
            ptb_minisize.Cursor = Cursors.Hand;
            ptb_minisize.Location = new Point(1233, 2);
            ptb_minisize.Name = "ptb_minisize";
            ptb_minisize.Size = new Size(33, 31);
            ptb_minisize.TabIndex = 1;
            ptb_minisize.Click += ptb_minisize_Click_1;
            ptb_minisize.Paint += ptb_minisize_Paint;
            // 
            // lb_logo
            // 
            lb_logo.AutoSize = true;
            lb_logo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lb_logo.ForeColor = Color.White;
            lb_logo.Location = new Point(45, 10);
            lb_logo.Name = "lb_logo";
            lb_logo.Size = new Size(127, 18);
            lb_logo.TabIndex = 1;
            lb_logo.Text = "Books Manager";
            // 
            // ptb_logo
            // 
            ptb_logo.BackColor = Color.LightCyan;
            ptb_logo.Controls.Add(ptb);
            ptb_logo.Location = new Point(4, 2);
            ptb_logo.Name = "ptb_logo";
            ptb_logo.Size = new Size(30, 31);
            ptb_logo.TabIndex = 0;
            // 
            // ptb
            // 
            ptb.Dock = DockStyle.Fill;
            ptb.Location = new Point(0, 0);
            ptb.Name = "ptb";
            ptb.Size = new Size(30, 31);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.TabIndex = 0;
            ptb.TabStop = false;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.LightSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 825);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(1340, 37);
            pn_bottom.TabIndex = 7;
            // 
            // pn_left
            // 
            pn_left.BackColor = Color.LightSlateGray;
            pn_left.Dock = DockStyle.Left;
            pn_left.Location = new Point(0, 37);
            pn_left.Name = "pn_left";
            pn_left.Size = new Size(15, 788);
            pn_left.TabIndex = 11;
            // 
            // pn_right
            // 
            pn_right.BackColor = Color.LightSlateGray;
            pn_right.Dock = DockStyle.Right;
            pn_right.Location = new Point(1325, 37);
            pn_right.Name = "pn_right";
            pn_right.Size = new Size(15, 788);
            pn_right.TabIndex = 12;
            // 
            // ms_content
            // 
            ms_content.Font = new Font("Microsoft Sans Serif", 9F);
            ms_content.ImageScalingSize = new Size(20, 20);
            ms_content.Items.AddRange(new ToolStripItem[] { sáchToolStripMenuItem, nhânViênToolStripMenuItem, toolStripMenuItem1, kháchHàngToolStripMenuItem, đơnHàngToolStripMenuItem });
            ms_content.Location = new Point(15, 37);
            ms_content.Name = "ms_content";
            ms_content.Size = new Size(1310, 26);
            ms_content.TabIndex = 16;
            ms_content.Text = "menuStrip1";
            // 
            // sáchToolStripMenuItem
            // 
            sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            sáchToolStripMenuItem.Size = new Size(66, 22);
            sáchToolStripMenuItem.Text = "Books";
            sáchToolStripMenuItem.Click += sáchToolStripMenuItem_Click;
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(60, 22);
            nhânViênToolStripMenuItem.Text = "Staffs";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 22);
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(96, 22);
            kháchHàngToolStripMenuItem.Text = "Customers";
            // 
            // đơnHàngToolStripMenuItem
            // 
            đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            đơnHàngToolStripMenuItem.Size = new Size(68, 22);
            đơnHàngToolStripMenuItem.Text = "Orders";
            // 
            // grb_content
            // 
            grb_content.BackColor = Color.LightSlateGray;
            grb_content.Dock = DockStyle.Fill;
            grb_content.Location = new Point(15, 63);
            grb_content.Name = "grb_content";
            grb_content.Size = new Size(1310, 762);
            grb_content.TabIndex = 17;
            grb_content.TabStop = false;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 862);
            Controls.Add(grb_content);
            Controls.Add(ms_content);
            Controls.Add(pn_right);
            Controls.Add(pn_left);
            Controls.Add(pn_top);
            Controls.Add(pn_bottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fMain";
            Text = "fMain";
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ptb_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb).EndInit();
            ms_content.ResumeLayout(false);
            ms_content.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pn_top;
        private Panel ptb_maxisize;
        private Panel ptb_close;
        private Panel ptb_minisize;
        private Label lb_logo;
        private Panel ptb_logo;
        private Panel pn_bottom;
        private Panel pn_left;
        private Panel pn_right;
        private MenuStrip ms_content;
        private GroupBox grb_content;
        private ToolStripMenuItem sáchToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;
        private PictureBox ptb;
    }
}