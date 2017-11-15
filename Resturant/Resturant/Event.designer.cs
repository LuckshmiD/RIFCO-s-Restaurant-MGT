namespace EventCaterMgt
{
    partial class Event
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
            this.label1 = new System.Windows.Forms.Label();
            this.ename = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Eid = new System.Windows.Forms.Label();
            this.cuscontact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.packcombo = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cusid = new System.Windows.Forms.Label();
            this.cusname = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.duhead = new System.Windows.Forms.Label();
            this.hdamount = new System.Windows.Forms.Label();
            this.duamount = new System.Windows.Forms.Label();
            this.packprice = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addPayment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Advance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dsrtcombo = new System.Windows.Forms.ComboBox();
            this.dsrt = new System.Windows.Forms.Label();
            this.eventOrder = new System.Windows.Forms.DataGridView();
            this.AddOrder = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ename
            // 
            this.ename.Location = new System.Drawing.Point(172, 114);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(200, 20);
            this.ename.TabIndex = 1;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(172, 169);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(200, 20);
            this.count.TabIndex = 3;
            this.count.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name of the Event";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date & Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Head Count";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Event Duration (hrs)";
            // 
            // Eid
            // 
            this.Eid.AutoSize = true;
            this.Eid.Location = new System.Drawing.Point(26, 94);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(91, 13);
            this.Eid.TabIndex = 17;
            this.Eid.Text = "Customer Contact";
            // 
            // cuscontact
            // 
            this.cuscontact.Location = new System.Drawing.Point(172, 87);
            this.cuscontact.Name = "cuscontact";
            this.cuscontact.Size = new System.Drawing.Size(200, 20);
            this.cuscontact.TabIndex = 18;
            this.cuscontact.CursorChanged += new System.EventHandler(this.cuscontact_CursorChanged);
            this.cuscontact.TextChanged += new System.EventHandler(this.cuscontact_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Package";
            // 
            // packcombo
            // 
            this.packcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packcombo.FormattingEnabled = true;
            this.packcombo.Location = new System.Drawing.Point(172, 228);
            this.packcombo.Name = "packcombo";
            this.packcombo.Size = new System.Drawing.Size(200, 21);
            this.packcombo.TabIndex = 21;
            this.packcombo.SelectedIndexChanged += new System.EventHandler(this.packcombo_SelectedIndexChanged);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(172, 139);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(130, 20);
            this.date.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(775, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Features";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 47;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(320, 140);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 20);
            this.time.TabIndex = 48;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(889, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // cusid
            // 
            this.cusid.AutoSize = true;
            this.cusid.Location = new System.Drawing.Point(134, 59);
            this.cusid.Name = "cusid";
            this.cusid.Size = new System.Drawing.Size(13, 13);
            this.cusid.TabIndex = 51;
            this.cusid.Text = "..";
            this.cusid.Click += new System.EventHandler(this.cusid_Click);
            // 
            // cusname
            // 
            this.cusname.AutoSize = true;
            this.cusname.Location = new System.Drawing.Point(169, 59);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(13, 13);
            this.cusname.TabIndex = 52;
            this.cusname.Text = "..";
            // 
            // duration
            // 
            this.duration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duration.FormattingEnabled = true;
            this.duration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.duration.Location = new System.Drawing.Point(172, 198);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(200, 21);
            this.duration.TabIndex = 53;
            this.duration.SelectedIndexChanged += new System.EventHandler(this.duration_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 54;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Customer Name";
            // 
            // duhead
            // 
            this.duhead.AutoSize = true;
            this.duhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duhead.Location = new System.Drawing.Point(542, 228);
            this.duhead.Name = "duhead";
            this.duhead.Size = new System.Drawing.Size(22, 24);
            this.duhead.TabIndex = 56;
            this.duhead.Text = "..";
            // 
            // hdamount
            // 
            this.hdamount.AutoSize = true;
            this.hdamount.Location = new System.Drawing.Point(382, 176);
            this.hdamount.Name = "hdamount";
            this.hdamount.Size = new System.Drawing.Size(13, 13);
            this.hdamount.TabIndex = 57;
            this.hdamount.Text = "..";
            // 
            // duamount
            // 
            this.duamount.AutoSize = true;
            this.duamount.Location = new System.Drawing.Point(382, 206);
            this.duamount.Name = "duamount";
            this.duamount.Size = new System.Drawing.Size(13, 13);
            this.duamount.TabIndex = 58;
            this.duamount.Text = "..";
            // 
            // packprice
            // 
            this.packprice.AutoSize = true;
            this.packprice.Location = new System.Drawing.Point(382, 236);
            this.packprice.Name = "packprice";
            this.packprice.Size = new System.Drawing.Size(13, 13);
            this.packprice.TabIndex = 59;
            this.packprice.Text = "..";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(554, 48);
            this.dataGridView2.TabIndex = 60;
            // 
            // addPayment
            // 
            this.addPayment.Location = new System.Drawing.Point(848, 347);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(116, 23);
            this.addPayment.TabIndex = 61;
            this.addPayment.Text = "Add payment";
            this.addPayment.UseVisualStyleBackColor = true;
            this.addPayment.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(671, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 162);
            this.dataGridView1.TabIndex = 63;
            // 
            // Advance
            // 
            this.Advance.AutoSize = true;
            this.Advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance.Location = new System.Drawing.Point(886, 384);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(16, 16);
            this.Advance.TabIndex = 65;
            this.Advance.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Advance Payment";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Total";
            // 
            // dsrtcombo
            // 
            this.dsrtcombo.FormattingEnabled = true;
            this.dsrtcombo.Location = new System.Drawing.Point(671, 297);
            this.dsrtcombo.Name = "dsrtcombo";
            this.dsrtcombo.Size = new System.Drawing.Size(242, 21);
            this.dsrtcombo.TabIndex = 62;
            this.dsrtcombo.Text = "Choose From Here";
            this.dsrtcombo.SelectedIndexChanged += new System.EventHandler(this.dsrtcombo_SelectedIndexChanged);
            // 
            // dsrt
            // 
            this.dsrt.AutoSize = true;
            this.dsrt.Location = new System.Drawing.Point(919, 300);
            this.dsrt.Name = "dsrt";
            this.dsrt.Size = new System.Drawing.Size(13, 13);
            this.dsrt.TabIndex = 64;
            this.dsrt.Text = "..";
            this.dsrt.Click += new System.EventHandler(this.dsrt_Click);
            // 
            // eventOrder
            // 
            this.eventOrder.AllowUserToAddRows = false;
            this.eventOrder.AllowUserToDeleteRows = false;
            this.eventOrder.AllowUserToResizeColumns = false;
            this.eventOrder.AllowUserToResizeRows = false;
            this.eventOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventOrder.Location = new System.Drawing.Point(10, 356);
            this.eventOrder.Name = "eventOrder";
            this.eventOrder.ReadOnly = true;
            this.eventOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventOrder.Size = new System.Drawing.Size(554, 150);
            this.eventOrder.TabIndex = 68;
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(759, 255);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(75, 23);
            this.AddOrder.TabIndex = 69;
            this.AddOrder.Text = "Add Design";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(570, 483);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 70;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.eventOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Advance);
            this.Controls.Add(this.dsrt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dsrtcombo);
            this.Controls.Add(this.addPayment);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.packprice);
            this.Controls.Add(this.duamount);
            this.Controls.Add(this.hdamount);
            this.Controls.Add(this.duhead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.cusname);
            this.Controls.Add(this.cusid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date);
            this.Controls.Add(this.packcombo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cuscontact);
            this.Controls.Add(this.Eid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ename;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Eid;
        private System.Windows.Forms.TextBox cuscontact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox packcombo;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label cusid;
        private System.Windows.Forms.Label cusname;
        private System.Windows.Forms.ComboBox duration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label duhead;
        private System.Windows.Forms.Label hdamount;
        private System.Windows.Forms.Label duamount;
        private System.Windows.Forms.Label packprice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addPayment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Advance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox dsrtcombo;
        private System.Windows.Forms.Label dsrt;
        private System.Windows.Forms.DataGridView eventOrder;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button Clear;
    }
}

