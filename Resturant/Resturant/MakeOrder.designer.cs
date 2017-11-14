namespace OrderManagement
{
    partial class MakeOrder
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
            this.menu = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemtagcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.psize = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.tableorder = new System.Windows.Forms.DataGridView();
            this.tablelabel = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableorder)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AllowUserToAddRows = false;
            this.menu.AllowUserToDeleteRows = false;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.menu.Location = new System.Drawing.Point(21, 63);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(651, 444);
            this.menu.TabIndex = 0;
            this.menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.menu.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.menu_CellMouseUp);
            this.menu.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Resturant.Properties.Resources.plus__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(787, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 38);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Resturant.Properties.Resources.success__1_;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1146, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 54);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1029, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order List";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // itemtagcombo
            // 
            this.itemtagcombo.FormattingEnabled = true;
            this.itemtagcombo.Items.AddRange(new object[] {
            "All",
            "Starters",
            "Main Course",
            "Chicken dishes",
            "Beef dishes",
            "Mutton dishes",
            "Seafood dishes",
            "Vegetarian dishes",
            "Burghers and Sandwiches",
            "Desserts",
            "Beverages"});
            this.itemtagcombo.Location = new System.Drawing.Point(126, 31);
            this.itemtagcombo.Name = "itemtagcombo";
            this.itemtagcombo.Size = new System.Drawing.Size(121, 21);
            this.itemtagcombo.TabIndex = 10;
            this.itemtagcombo.SelectedIndexChanged += new System.EventHandler(this.itemtagcombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Resturant.Properties.Resources.search__1_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(253, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // itemcode
            // 
            this.itemcode.Enabled = false;
            this.itemcode.Location = new System.Drawing.Point(804, 128);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(100, 21);
            this.itemcode.TabIndex = 13;
            this.itemcode.TextChanged += new System.EventHandler(this.itemcode_TextChanged);
            // 
            // itemname
            // 
            this.itemname.Enabled = false;
            this.itemname.Location = new System.Drawing.Point(804, 179);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(100, 21);
            this.itemname.TabIndex = 14;
            this.itemname.TextChanged += new System.EventHandler(this.itemname_TextChanged);
            // 
            // rate
            // 
            this.rate.Enabled = false;
            this.rate.Location = new System.Drawing.Point(804, 299);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 21);
            this.rate.TabIndex = 17;
            this.rate.TextChanged += new System.EventHandler(this.rate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Item Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(743, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Rate";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(804, 353);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(57, 21);
            this.qty.TabIndex = 23;
            this.qty.ValueChanged += new System.EventHandler(this.qty_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(731, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Portion Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // psize
            // 
            this.psize.Enabled = false;
            this.psize.Location = new System.Drawing.Point(804, 241);
            this.psize.Name = "psize";
            this.psize.Size = new System.Drawing.Size(100, 21);
            this.psize.TabIndex = 25;
            this.psize.TextChanged += new System.EventHandler(this.psize_TextChanged);
            // 
            // remove
            // 
            this.remove.BackgroundImage = global::Resturant.Properties.Resources.minus__1_;
            this.remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.remove.FlatAppearance.BorderSize = 0;
            this.remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Location = new System.Drawing.Point(1047, 446);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(36, 38);
            this.remove.TabIndex = 28;
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            this.remove.MouseLeave += new System.EventHandler(this.remove_MouseLeave);
            this.remove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.remove_MouseMove);
            // 
            // tableorder
            // 
            this.tableorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableorder.Location = new System.Drawing.Point(933, 93);
            this.tableorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableorder.Name = "tableorder";
            this.tableorder.RowTemplate.Height = 24;
            this.tableorder.Size = new System.Drawing.Size(267, 348);
            this.tableorder.TabIndex = 32;
            this.tableorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableorder_CellContentClick);
            this.tableorder.Click += new System.EventHandler(this.tableorder_Click);
            // 
            // tablelabel
            // 
            this.tablelabel.AutoSize = true;
            this.tablelabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablelabel.Location = new System.Drawing.Point(555, 9);
            this.tablelabel.Name = "tablelabel";
            this.tablelabel.Size = new System.Drawing.Size(68, 16);
            this.tablelabel.TabIndex = 33;
            this.tablelabel.Text = "Table No :";
            this.tablelabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackgroundImage = global::Resturant.Properties.Resources.error__1_;
            this.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Location = new System.Drawing.Point(1167, 12);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(36, 38);
            this.CloseWindow.TabIndex = 34;
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            this.CloseWindow.MouseLeave += new System.EventHandler(this.CloseWindow_MouseLeave);
            this.CloseWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseWindow_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Item Tag";
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 587);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.tablelabel);
            this.Controls.Add(this.tableorder);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.psize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.itemcode);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemtagcombo);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MakeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeOrder";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemtagcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox itemcode;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox psize;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.DataGridView tableorder;
        private System.Windows.Forms.Label tablelabel;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Label label6;
    }
}