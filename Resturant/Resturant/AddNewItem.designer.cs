namespace OrderManagement
{
    partial class AddNewItem
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
            this.psizef = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemnamef = new System.Windows.Forms.TextBox();
            this.itemnamesearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.updateItem = new System.Windows.Forms.Button();
            this.desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.itemtagf = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ingredients = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.itemcode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.totalprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.imagebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ingredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // psizef
            // 
            this.psizef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.psizef.FormattingEnabled = true;
            this.psizef.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.psizef.Location = new System.Drawing.Point(107, 245);
            this.psizef.Name = "psizef";
            this.psizef.Size = new System.Drawing.Size(133, 21);
            this.psizef.TabIndex = 19;
            this.psizef.SelectedIndexChanged += new System.EventHandler(this.psizef_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Portion Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(955, 162);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 42);
            this.AddItem.TabIndex = 17;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Find by Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Edit Item in Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemnamef
            // 
            this.itemnamef.Location = new System.Drawing.Point(107, 81);
            this.itemnamef.Multiline = true;
            this.itemnamef.Name = "itemnamef";
            this.itemnamef.Size = new System.Drawing.Size(133, 44);
            this.itemnamef.TabIndex = 11;
            this.itemnamef.TextChanged += new System.EventHandler(this.itemnamef_TextChanged);
            // 
            // itemnamesearch
            // 
            this.itemnamesearch.Location = new System.Drawing.Point(145, 380);
            this.itemnamesearch.Name = "itemnamesearch";
            this.itemnamesearch.Size = new System.Drawing.Size(100, 20);
            this.itemnamesearch.TabIndex = 10;
            this.itemnamesearch.TextChanged += new System.EventHandler(this.itemcodef_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 465);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateItem
            // 
            this.updateItem.Location = new System.Drawing.Point(955, 223);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(75, 43);
            this.updateItem.TabIndex = 23;
            this.updateItem.Text = "Update Item Details";
            this.updateItem.UseVisualStyleBackColor = true;
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(107, 133);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(133, 105);
            this.desc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Item Tag";
            // 
            // itemtagf
            // 
            this.itemtagf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemtagf.FormattingEnabled = true;
            this.itemtagf.Items.AddRange(new object[] {
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
            this.itemtagf.Location = new System.Drawing.Point(107, 275);
            this.itemtagf.Name = "itemtagf";
            this.itemtagf.Size = new System.Drawing.Size(133, 21);
            this.itemtagf.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(273, 176);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingredient ";
            // 
            // ingredients
            // 
            this.ingredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ingredients.Controls.Add(this.button6);
            this.ingredients.Controls.Add(this.itemcode);
            this.ingredients.Controls.Add(this.label12);
            this.ingredients.Controls.Add(this.button5);
            this.ingredients.Controls.Add(this.button4);
            this.ingredients.Controls.Add(this.totalprice);
            this.ingredients.Controls.Add(this.label11);
            this.ingredients.Controls.Add(this.button3);
            this.ingredients.Controls.Add(this.quantity);
            this.ingredients.Controls.Add(this.dataGridView2);
            this.ingredients.Controls.Add(this.label7);
            this.ingredients.Controls.Add(this.label9);
            this.ingredients.Controls.Add(this.comboBox1);
            this.ingredients.Location = new System.Drawing.Point(624, 61);
            this.ingredients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(307, 325);
            this.ingredients.TabIndex = 34;
            this.ingredients.Paint += new System.Windows.Forms.PaintEventHandler(this.ingredients_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(242, 32);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 41);
            this.button6.TabIndex = 44;
            this.button6.Text = "Item Price";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // itemcode
            // 
            this.itemcode.Location = new System.Drawing.Point(110, 9);
            this.itemcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(116, 19);
            this.itemcode.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "ItemCode";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 297);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 41;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 294);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 22);
            this.button4.TabIndex = 40;
            this.button4.Text = "Add ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalprice
            // 
            this.totalprice.Location = new System.Drawing.Point(112, 79);
            this.totalprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(115, 20);
            this.totalprice.TabIndex = 39;
            this.totalprice.TextChanged += new System.EventHandler(this.totalprice_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 83);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Totalprice";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 20);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(112, 55);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(115, 20);
            this.quantity.TabIndex = 36;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantity_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(661, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingredients";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(107, 300);
            this.status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(59, 21);
            this.status.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 302);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Status";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackgroundImage = global::Resturant.Properties.Resources.error__1_;
            this.CloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Location = new System.Drawing.Point(985, 12);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(45, 43);
            this.CloseWindow.TabIndex = 37;
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            this.CloseWindow.MouseLeave += new System.EventHandler(this.CloseWindow_MouseLeave);
            this.CloseWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseWindow_MouseMove);
            // 
            // imagebox
            // 
            this.imagebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagebox.Location = new System.Drawing.Point(291, 81);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(311, 205);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 21;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.imagebox_Click);
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1042, 884);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.itemtagf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.updateItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.psizef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemnamef);
            this.Controls.Add(this.itemnamesearch);
            this.Controls.Add(this.ingredients);
            this.Name = "AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItem";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ingredients.ResumeLayout(false);
            this.ingredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox psizef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemnamef;
        private System.Windows.Forms.TextBox itemnamesearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateItem;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox itemtagf;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ingredients;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label itemcode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button CloseWindow;
    }
}