namespace OrderManagement
{
    partial class TakeawayMenu
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
            this.tableorder = new System.Windows.Forms.DataGridView();
            this.remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.psize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.itemcode = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemtagcombo = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableorder
            // 
            this.tableorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableorder.Location = new System.Drawing.Point(1260, 171);
            this.tableorder.Name = "tableorder";
            this.tableorder.RowTemplate.Height = 24;
            this.tableorder.Size = new System.Drawing.Size(356, 428);
            this.tableorder.TabIndex = 51;
            this.tableorder.Click += new System.EventHandler(this.tableorder_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(1394, 628);
            this.remove.Margin = new System.Windows.Forms.Padding(4);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(100, 28);
            this.remove.TabIndex = 50;
            this.remove.Text = "Remove Item";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Portion Size";
            // 
            // psize
            // 
            this.psize.Enabled = false;
            this.psize.Location = new System.Drawing.Point(1075, 355);
            this.psize.Margin = new System.Windows.Forms.Padding(4);
            this.psize.Name = "psize";
            this.psize.Size = new System.Drawing.Size(132, 22);
            this.psize.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(993, 510);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Quantity";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(1075, 508);
            this.qty.Margin = new System.Windows.Forms.Padding(4);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(75, 22);
            this.qty.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(993, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(977, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(981, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Item Code";
            // 
            // rate
            // 
            this.rate.Enabled = false;
            this.rate.Location = new System.Drawing.Point(1075, 426);
            this.rate.Margin = new System.Windows.Forms.Padding(4);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(132, 22);
            this.rate.TabIndex = 42;
            // 
            // itemname
            // 
            this.itemname.Enabled = false;
            this.itemname.Location = new System.Drawing.Point(1075, 279);
            this.itemname.Margin = new System.Windows.Forms.Padding(4);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(132, 22);
            this.itemname.TabIndex = 41;
            // 
            // itemcode
            // 
            this.itemcode.Enabled = false;
            this.itemcode.Location = new System.Drawing.Point(1075, 216);
            this.itemcode.Margin = new System.Windows.Forms.Padding(4);
            this.itemcode.Name = "itemcode";
            this.itemcode.Size = new System.Drawing.Size(132, 22);
            this.itemcode.TabIndex = 40;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 100);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 26);
            this.button5.TabIndex = 39;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 38;
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
            this.itemtagcombo.Location = new System.Drawing.Point(178, 100);
            this.itemtagcombo.Margin = new System.Windows.Forms.Padding(4);
            this.itemtagcombo.Name = "itemtagcombo";
            this.itemtagcombo.Size = new System.Drawing.Size(160, 24);
            this.itemtagcombo.TabIndex = 37;
            // 
            // menu
            // 
            this.menu.AllowUserToAddRows = false;
            this.menu.AllowUserToDeleteRows = false;
            this.menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.menu.Location = new System.Drawing.Point(45, 134);
            this.menu.Margin = new System.Windows.Forms.Padding(4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(869, 546);
            this.menu.TabIndex = 33;
            this.menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menu_CellContentClick);
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1389, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Order List";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1431, 700);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 44);
            this.button4.TabIndex = 35;
            this.button4.Text = "Finalize Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1022, 579);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 59);
            this.button3.TabIndex = 34;
            this.button3.Text = "ADD ITEM TO ORDER LIST";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TakeawayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 845);
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
            this.Name = "TakeawayMenu";
            this.Text = "TakeawayMenu";
            this.Load += new System.EventHandler(this.TakeawayMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableorder;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox psize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox itemcode;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemtagcombo;
        private System.Windows.Forms.DataGridView menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}