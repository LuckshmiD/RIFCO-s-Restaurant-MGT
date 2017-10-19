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
            this.imagebox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.ingredients.SuspendLayout();
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
            this.psizef.Location = new System.Drawing.Point(143, 322);
            this.psizef.Margin = new System.Windows.Forms.Padding(4);
            this.psizef.Name = "psizef";
            this.psizef.Size = new System.Drawing.Size(176, 24);
            this.psizef.TabIndex = 19;
            this.psizef.SelectedIndexChanged += new System.EventHandler(this.psizef_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Portion Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(667, 144);
            this.AddItem.Margin = new System.Windows.Forms.Padding(4);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(100, 52);
            this.AddItem.TabIndex = 17;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1051, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Find by Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Edit Item in Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemnamef
            // 
            this.itemnamef.Location = new System.Drawing.Point(143, 121);
            this.itemnamef.Margin = new System.Windows.Forms.Padding(4);
            this.itemnamef.Multiline = true;
            this.itemnamef.Name = "itemnamef";
            this.itemnamef.Size = new System.Drawing.Size(176, 53);
            this.itemnamef.TabIndex = 11;
            this.itemnamef.TextChanged += new System.EventHandler(this.itemnamef_TextChanged);
            // 
            // itemnamesearch
            // 
            this.itemnamesearch.Location = new System.Drawing.Point(1197, 96);
            this.itemnamesearch.Margin = new System.Windows.Forms.Padding(4);
            this.itemnamesearch.Name = "itemnamesearch";
            this.itemnamesearch.Size = new System.Drawing.Size(132, 22);
            this.itemnamesearch.TabIndex = 10;
            this.itemnamesearch.TextChanged += new System.EventHandler(this.itemcodef_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(775, 144);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 524);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // imagebox
            // 
            this.imagebox.Location = new System.Drawing.Point(28, 431);
            this.imagebox.Margin = new System.Windows.Forms.Padding(4);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(313, 191);
            this.imagebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagebox.TabIndex = 21;
            this.imagebox.TabStop = false;
            this.imagebox.Click += new System.EventHandler(this.imagebox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Choose Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateItem
            // 
            this.updateItem.Location = new System.Drawing.Point(667, 219);
            this.updateItem.Margin = new System.Windows.Forms.Padding(4);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(100, 53);
            this.updateItem.TabIndex = 23;
            this.updateItem.Text = "Update Item Details";
            this.updateItem.UseVisualStyleBackColor = true;
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(143, 185);
            this.desc.Margin = new System.Windows.Forms.Padding(4);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(176, 128);
            this.desc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1361, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 362);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
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
            this.itemtagf.Location = new System.Drawing.Point(143, 359);
            this.itemtagf.Margin = new System.Windows.Forms.Padding(4);
            this.itemtagf.Name = "itemtagf";
            this.itemtagf.Size = new System.Drawing.Size(176, 24);
            this.itemtagf.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 126);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(364, 217);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ingredient ";
            // 
            // ingredients
            // 
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
            this.ingredients.Location = new System.Drawing.Point(359, 279);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(409, 389);
            this.ingredients.TabIndex = 34;
            this.ingredients.Paint += new System.Windows.Forms.PaintEventHandler(this.ingredients_Paint);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(322, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 51);
            this.button6.TabIndex = 44;
            this.button6.Text = "Item Price";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // itemcode
            // 
            this.itemcode.Location = new System.Drawing.Point(147, 11);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(155, 23);
            this.itemcode.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "ItemCode";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 27);
            this.button4.TabIndex = 40;
            this.button4.Text = "Add ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalprice
            // 
            this.totalprice.Location = new System.Drawing.Point(150, 97);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(152, 22);
            this.totalprice.TabIndex = 39;
            this.totalprice.TextChanged += new System.EventHandler(this.totalprice_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Totalprice";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 364);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 25);
            this.button3.TabIndex = 37;
            this.button3.Text = "Delete row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(150, 68);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(152, 22);
            this.quantity.TabIndex = 36;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantity_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingredients";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.status.Location = new System.Drawing.Point(143, 390);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(77, 24);
            this.status.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Status";
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1805, 693);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewItem";
            this.Text = "AddNewItem";
            this.Load += new System.EventHandler(this.AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ingredients.ResumeLayout(false);
            this.ingredients.PerformLayout();
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
    }
}