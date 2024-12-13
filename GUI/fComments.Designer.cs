namespace QL_TruongHoc.GUI
{
    partial class fComments
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
            panel1 = new Panel();
            ptb_close = new Panel();
            ptb_maxisize = new Panel();
            ptb_minisize = new Panel();
            lb_logo = new Label();
            ptb_logo = new Panel();
            ptb = new PictureBox();
            panel2 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            pn_top.SuspendLayout();
            ptb_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.LightSlateGray;
            pn_top.Controls.Add(panel1);
            pn_top.Controls.Add(ptb_close);
            pn_top.Controls.Add(ptb_maxisize);
            pn_top.Controls.Add(ptb_minisize);
            pn_top.Controls.Add(lb_logo);
            pn_top.Controls.Add(ptb_logo);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(349, 37);
            pn_top.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.LightCyan;
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(313, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(33, 31);
            panel1.TabIndex = 4;
            panel1.Click += panel1_Click;
            // 
            // ptb_close
            // 
            ptb_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_close.BackColor = Color.LightCyan;
            ptb_close.Cursor = Cursors.Hand;
            ptb_close.Location = new Point(1452, 2);
            ptb_close.Name = "ptb_close";
            ptb_close.Size = new Size(33, 31);
            ptb_close.TabIndex = 2;
            // 
            // ptb_maxisize
            // 
            ptb_maxisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_maxisize.BackColor = Color.LightCyan;
            ptb_maxisize.Cursor = Cursors.Hand;
            ptb_maxisize.Location = new Point(1417, 2);
            ptb_maxisize.Name = "ptb_maxisize";
            ptb_maxisize.Size = new Size(33, 31);
            ptb_maxisize.TabIndex = 3;
            // 
            // ptb_minisize
            // 
            ptb_minisize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ptb_minisize.BackColor = Color.LightCyan;
            ptb_minisize.Cursor = Cursors.Hand;
            ptb_minisize.Location = new Point(1382, 2);
            ptb_minisize.Name = "ptb_minisize";
            ptb_minisize.Size = new Size(33, 31);
            ptb_minisize.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 413);
            panel2.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(349, 413);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Comment";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Like";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Dislike";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date";
            // 
            // fComments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(349, 450);
            Controls.Add(panel2);
            Controls.Add(pn_top);
            Name = "fComments";
            Text = "fComments";
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ptb_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_top;
        private Panel ptb_close;
        private Panel ptb_maxisize;
        private Panel ptb_minisize;
        private Label lb_logo;
        private Panel ptb_logo;
        private PictureBox ptb;
        private Panel panel1;
        private Panel panel2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}