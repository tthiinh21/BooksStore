namespace QL_TruongHoc.GUI
{
    partial class fOrder
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
            panel1 = new Panel();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ccb_pay = new ComboBox();
            btn_add_order = new Button();
            btn_delete_order = new Button();
            btn_edit_order = new Button();
            label9 = new Label();
            txt_note = new RichTextBox();
            label8 = new Label();
            txt_order_total = new TextBox();
            label7 = new Label();
            txt_order_shipping = new TextBox();
            label6 = new Label();
            txt_order_date = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_order_customer = new TextBox();
            label3 = new Label();
            txt_order_code = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            ccb_customer_search = new ComboBox();
            btn_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1289, 55);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1289, 655);
            splitContainer1.SplitterDistance = 570;
            splitContainer1.SplitterWidth = 24;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btn_search);
            splitContainer2.Panel1.Controls.Add(ccb_customer_search);
            splitContainer2.Panel1.Controls.Add(ccb_pay);
            splitContainer2.Panel1.Controls.Add(btn_add_order);
            splitContainer2.Panel1.Controls.Add(btn_delete_order);
            splitContainer2.Panel1.Controls.Add(btn_edit_order);
            splitContainer2.Panel1.Controls.Add(label9);
            splitContainer2.Panel1.Controls.Add(txt_note);
            splitContainer2.Panel1.Controls.Add(label8);
            splitContainer2.Panel1.Controls.Add(txt_order_total);
            splitContainer2.Panel1.Controls.Add(label7);
            splitContainer2.Panel1.Controls.Add(txt_order_shipping);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(txt_order_date);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(txt_order_customer);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(txt_order_code);
            splitContainer2.Panel1.Controls.Add(label2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView2);
            splitContainer2.Size = new Size(570, 655);
            splitContainer2.SplitterDistance = 479;
            splitContainer2.TabIndex = 0;
            // 
            // ccb_pay
            // 
            ccb_pay.FormattingEnabled = true;
            ccb_pay.Location = new Point(424, 145);
            ccb_pay.Name = "ccb_pay";
            ccb_pay.Size = new Size(128, 28);
            ccb_pay.TabIndex = 23;
            // 
            // btn_add_order
            // 
            btn_add_order.Anchor = AnchorStyles.Top;
            btn_add_order.BackColor = Color.LightSlateGray;
            btn_add_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_add_order.ForeColor = Color.White;
            btn_add_order.Location = new Point(22, 16);
            btn_add_order.Name = "btn_add_order";
            btn_add_order.Size = new Size(126, 30);
            btn_add_order.TabIndex = 22;
            btn_add_order.Text = "Add new order";
            btn_add_order.UseVisualStyleBackColor = false;
            btn_add_order.Click += btn_add_order_Click;
            // 
            // btn_delete_order
            // 
            btn_delete_order.Anchor = AnchorStyles.Top;
            btn_delete_order.BackColor = Color.LightSlateGray;
            btn_delete_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_delete_order.ForeColor = Color.White;
            btn_delete_order.Location = new Point(452, 431);
            btn_delete_order.Name = "btn_delete_order";
            btn_delete_order.Size = new Size(100, 30);
            btn_delete_order.TabIndex = 21;
            btn_delete_order.Text = "Delete";
            btn_delete_order.UseVisualStyleBackColor = false;
            btn_delete_order.Click += btn_delete_order_Click;
            // 
            // btn_edit_order
            // 
            btn_edit_order.Anchor = AnchorStyles.Top;
            btn_edit_order.BackColor = Color.LightSlateGray;
            btn_edit_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_edit_order.ForeColor = Color.White;
            btn_edit_order.Location = new Point(115, 431);
            btn_edit_order.Name = "btn_edit_order";
            btn_edit_order.Size = new Size(100, 30);
            btn_edit_order.TabIndex = 20;
            btn_edit_order.Text = "Edit";
            btn_edit_order.UseVisualStyleBackColor = false;
            btn_edit_order.Click += btn_edit_order_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(27, 268);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 14;
            label9.Text = "Note:";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(115, 268);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(437, 137);
            txt_note.TabIndex = 13;
            txt_note.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(324, 220);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 12;
            label8.Text = "Total:";
            // 
            // txt_order_total
            // 
            txt_order_total.Location = new Point(427, 217);
            txt_order_total.Name = "txt_order_total";
            txt_order_total.ReadOnly = true;
            txt_order_total.Size = new Size(125, 27);
            txt_order_total.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 224);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 10;
            label7.Text = "Shipping:";
            // 
            // txt_order_shipping
            // 
            txt_order_shipping.Location = new Point(115, 220);
            txt_order_shipping.Name = "txt_order_shipping";
            txt_order_shipping.Size = new Size(125, 27);
            txt_order_shipping.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(324, 184);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 8;
            label6.Text = "Order Date:";
            // 
            // txt_order_date
            // 
            txt_order_date.Location = new Point(427, 181);
            txt_order_date.Name = "txt_order_date";
            txt_order_date.Size = new Size(125, 27);
            txt_order_date.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(324, 146);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 6;
            label5.Text = "Pay Method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 188);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Customer:";
            // 
            // txt_order_customer
            // 
            txt_order_customer.Location = new Point(115, 184);
            txt_order_customer.Name = "txt_order_customer";
            txt_order_customer.ReadOnly = true;
            txt_order_customer.Size = new Size(125, 27);
            txt_order_customer.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 150);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Code:";
            // 
            // txt_order_code
            // 
            txt_order_code.Location = new Point(115, 146);
            txt_order_code.Name = "txt_order_code";
            txt_order_code.ReadOnly = true;
            txt_order_code.Size = new Size(125, 27);
            txt_order_code.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(570, 55);
            label2.TabIndex = 0;
            label2.Text = "Order Infor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(570, 172);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(695, 655);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // ccb_customer_search
            // 
            ccb_customer_search.FormattingEnabled = true;
            ccb_customer_search.Location = new Point(115, 60);
            ccb_customer_search.Name = "ccb_customer_search";
            ccb_customer_search.Size = new Size(125, 28);
            ccb_customer_search.TabIndex = 24;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top;
            btn_search.BackColor = Color.LightSlateGray;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(22, 58);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(79, 30);
            btn_search.TabIndex = 25;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // fOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1289, 710);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "fOrder";
            Text = "fOrder";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView2;
        private TextBox txt_order_code;
        private Label label2;
        private Label label3;
        private Label label8;
        private TextBox txt_order_total;
        private Label label7;
        private TextBox txt_order_shipping;
        private Label label6;
        private TextBox txt_order_date;
        private Label label5;
        private Label label4;
        private TextBox txt_order_customer;
        private Label label9;
        private RichTextBox txt_note;
        private Button btn_add_order;
        private Button btn_delete_order;
        private Button btn_edit_order;
        private ComboBox ccb_pay;
        private Button btn_search;
        private ComboBox ccb_customer_search;
    }
}