namespace QL_TruongHoc.GUI
{
    partial class fAddNewOrder
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
            splitContainer1 = new SplitContainer();
            ccb_customers = new ComboBox();
            ccb_payment = new ComboBox();
            btn_create_order = new Button();
            label9 = new Label();
            txt_note = new RichTextBox();
            label8 = new Label();
            txt_order_total = new TextBox();
            label7 = new Label();
            txt_order_shipping = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            BookSelect = new DataGridViewCheckBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ccb_customers);
            splitContainer1.Panel1.Controls.Add(ccb_payment);
            splitContainer1.Panel1.Controls.Add(btn_create_order);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(txt_note);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(txt_order_total);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(txt_order_shipping);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(982, 453);
            splitContainer1.SplitterDistance = 427;
            splitContainer1.TabIndex = 0;
            // 
            // ccb_customers
            // 
            ccb_customers.FormattingEnabled = true;
            ccb_customers.Location = new Point(123, 51);
            ccb_customers.Name = "ccb_customers";
            ccb_customers.Size = new Size(292, 28);
            ccb_customers.TabIndex = 38;
            // 
            // ccb_payment
            // 
            ccb_payment.FormattingEnabled = true;
            ccb_payment.Location = new Point(123, 126);
            ccb_payment.Name = "ccb_payment";
            ccb_payment.Size = new Size(292, 28);
            ccb_payment.TabIndex = 37;
            // 
            // btn_create_order
            // 
            btn_create_order.Anchor = AnchorStyles.Top;
            btn_create_order.BackColor = Color.LightSlateGray;
            btn_create_order.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_create_order.ForeColor = Color.White;
            btn_create_order.Location = new Point(160, 402);
            btn_create_order.Name = "btn_create_order";
            btn_create_order.Size = new Size(100, 30);
            btn_create_order.TabIndex = 36;
            btn_create_order.Text = "Create";
            btn_create_order.UseVisualStyleBackColor = false;
            btn_create_order.Click += btn_create_order_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(21, 206);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 35;
            label9.Text = "Note:";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(123, 206);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(292, 137);
            txt_note.TabIndex = 34;
            txt_note.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 168);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 33;
            label8.Text = "Total:";
            // 
            // txt_order_total
            // 
            txt_order_total.Location = new Point(124, 165);
            txt_order_total.Name = "txt_order_total";
            txt_order_total.ReadOnly = true;
            txt_order_total.Size = new Size(291, 27);
            txt_order_total.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 90);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 31;
            label7.Text = "Shipping:";
            // 
            // txt_order_shipping
            // 
            txt_order_shipping.Location = new Point(124, 90);
            txt_order_shipping.Name = "txt_order_shipping";
            txt_order_shipping.Size = new Size(291, 27);
            txt_order_shipping.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 129);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 27;
            label5.Text = "Pay Method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 54);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 25;
            label4.Text = "Customer:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookSelect, Quantity });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(551, 453);
            dataGridView1.TabIndex = 0;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookSelect
            // 
            BookSelect.HeaderText = "Select";
            BookSelect.MinimumWidth = 6;
            BookSelect.Name = "BookSelect";
            BookSelect.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // fAddNewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(982, 453);
            Controls.Add(splitContainer1);
            Name = "fAddNewOrder";
            Text = "fAddNewOrder";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn BookSelect;
        private DataGridViewTextBoxColumn Quantity;
        private Button btn_create_order;
        private Label label9;
        private RichTextBox txt_note;
        private Label label8;
        private TextBox txt_order_total;
        private Label label7;
        private TextBox txt_order_shipping;
        private Label label5;
        private Label label4;
        private TextBox txt_order_customer;
        private ComboBox ccb_payment;
        private ComboBox ccb_customers;
    }
}