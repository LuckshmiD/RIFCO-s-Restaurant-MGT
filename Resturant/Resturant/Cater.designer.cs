namespace EventCaterMgt
{
    partial class Cater
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
            this.Cid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cuscontact = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cusname = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.duration = new System.Windows.Forms.ComboBox();
            this.cusid = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.duamount = new System.Windows.Forms.Label();
            this.duhead = new System.Windows.Forms.Label();
            this.hdamount = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.Advance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.enter = new System.Windows.Forms.Button();
            this.Item1 = new System.Windows.Forms.Label();
            this.dsrt = new System.Windows.Forms.Label();
            this.Itot = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(116, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catering Order";
            // 
            // Cid
            // 
            this.Cid.AutoSize = true;
            this.Cid.Location = new System.Drawing.Point(12, 101);
            this.Cid.Name = "Cid";
            this.Cid.Size = new System.Drawing.Size(91, 13);
            this.Cid.TabIndex = 1;
            this.Cid.Text = "Customer Contact";
            this.Cid.Click += new System.EventHandler(this.Cid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date & Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Head Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Event Duration (hrs)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // cuscontact
            // 
            this.cuscontact.Location = new System.Drawing.Point(145, 93);
            this.cuscontact.Name = "cuscontact";
            this.cuscontact.Size = new System.Drawing.Size(200, 20);
            this.cuscontact.TabIndex = 7;
            this.cuscontact.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(145, 168);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(200, 20);
            this.count.TabIndex = 8;
            this.count.TextChanged += new System.EventHandler(this.count_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(145, 242);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 20);
            this.address.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Make Payment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Main Menu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Beverge and Dessert";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(145, 129);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(133, 20);
            this.date.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Customer Name";
            // 
            // cusname
            // 
            this.cusname.AutoSize = true;
            this.cusname.Location = new System.Drawing.Point(142, 66);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(13, 13);
            this.cusname.TabIndex = 47;
            this.cusname.Text = "..";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(293, 129);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 20);
            this.time.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(242, 229);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.dataGridView1_ChangeUICues);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(883, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(732, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(240, 229);
            this.dataGridView2.TabIndex = 51;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
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
            this.duration.Location = new System.Drawing.Point(145, 206);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(200, 21);
            this.duration.TabIndex = 52;
            this.duration.SelectedIndexChanged += new System.EventHandler(this.duration_SelectedIndexChanged);
            // 
            // cusid
            // 
            this.cusid.AutoSize = true;
            this.cusid.Location = new System.Drawing.Point(117, 66);
            this.cusid.Name = "cusid";
            this.cusid.Size = new System.Drawing.Size(13, 13);
            this.cusid.TabIndex = 53;
            this.cusid.Text = "..";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 21);
            this.button4.TabIndex = 54;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // duamount
            // 
            this.duamount.AutoSize = true;
            this.duamount.Location = new System.Drawing.Point(351, 209);
            this.duamount.Name = "duamount";
            this.duamount.Size = new System.Drawing.Size(13, 13);
            this.duamount.TabIndex = 55;
            this.duamount.Text = "..";
            this.duamount.Click += new System.EventHandler(this.label8_Click);
            // 
            // duhead
            // 
            this.duhead.AutoSize = true;
            this.duhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duhead.Location = new System.Drawing.Point(419, 416);
            this.duhead.Name = "duhead";
            this.duhead.Size = new System.Drawing.Size(22, 24);
            this.duhead.TabIndex = 56;
            this.duhead.Text = "..";
            this.duhead.Click += new System.EventHandler(this.duhead_Click);
            // 
            // hdamount
            // 
            this.hdamount.AutoSize = true;
            this.hdamount.Location = new System.Drawing.Point(351, 174);
            this.hdamount.Name = "hdamount";
            this.hdamount.Size = new System.Drawing.Size(13, 13);
            this.hdamount.TabIndex = 57;
            this.hdamount.Text = "..";
            this.hdamount.Click += new System.EventHandler(this.hdamount_Click);
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(729, 324);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(13, 13);
            this.price1.TabIndex = 60;
            this.price1.Text = "0";
            this.price1.Click += new System.EventHandler(this.meal_Click);
            // 
            // Advance
            // 
            this.Advance.AutoSize = true;
            this.Advance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance.Location = new System.Drawing.Point(755, 424);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(16, 16);
            this.Advance.TabIndex = 62;
            this.Advance.Text = "..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Advance Payment";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Total";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Location = new System.Drawing.Point(120, 324);
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderGrid.Size = new System.Drawing.Size(240, 150);
            this.orderGrid.TabIndex = 67;
            this.orderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellContentClick);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(12, 368);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 68;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.Location = new System.Drawing.Point(420, 324);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(27, 13);
            this.Item1.TabIndex = 71;
            this.Item1.Text = "Item";
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // dsrt
            // 
            this.dsrt.AutoSize = true;
            this.dsrt.Location = new System.Drawing.Point(704, 362);
            this.dsrt.Name = "dsrt";
            this.dsrt.Size = new System.Drawing.Size(13, 13);
            this.dsrt.TabIndex = 61;
            this.dsrt.Text = "..";
            // 
            // Itot
            // 
            this.Itot.AutoSize = true;
            this.Itot.Location = new System.Drawing.Point(25, 285);
            this.Itot.Name = "Itot";
            this.Itot.Size = new System.Drawing.Size(13, 13);
            this.Itot.TabIndex = 72;
            this.Itot.Text = "0";
            this.Itot.Click += new System.EventHandler(this.Itot_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(12, 339);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 73;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(729, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Price";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Cater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Itot);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Advance);
            this.Controls.Add(this.dsrt);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.hdamount);
            this.Controls.Add(this.duhead);
            this.Controls.Add(this.duamount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cusid);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.cusname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.count);
            this.Controls.Add(this.cuscontact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cater";
            this.Load += new System.EventHandler(this.Cater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cuscontact;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cusname;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox duration;
        private System.Windows.Forms.Label cusid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label duamount;
        private System.Windows.Forms.Label duhead;
        private System.Windows.Forms.Label hdamount;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label Advance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label Item1;
        private System.Windows.Forms.Label dsrt;
        private System.Windows.Forms.Label Itot;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label11;
    }
}