namespace OrderManagement
{
    partial class DeleteItem
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
            this.DeleteItemCode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemcodef = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.DataGridView();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete Item from Menu";
            // 
            // DeleteItemCode
            // 
            this.DeleteItemCode.Location = new System.Drawing.Point(184, 364);
            this.DeleteItemCode.Name = "DeleteItemCode";
            this.DeleteItemCode.Size = new System.Drawing.Size(75, 23);
            this.DeleteItemCode.TabIndex = 1;
            this.DeleteItemCode.Text = "Delete Item";
            this.DeleteItemCode.UseVisualStyleBackColor = true;
            this.DeleteItemCode.Click += new System.EventHandler(this.DeleteItemCode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Item Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // itemcodef
            // 
            this.itemcodef.Location = new System.Drawing.Point(156, 272);
            this.itemcodef.Name = "itemcodef";
            this.itemcodef.Size = new System.Drawing.Size(129, 20);
            this.itemcodef.TabIndex = 5;
            this.itemcodef.TextChanged += new System.EventHandler(this.itemcodef_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Item Code";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Display
            // 
            this.Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Display.Location = new System.Drawing.Point(440, 95);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(360, 314);
            this.Display.TabIndex = 9;
            this.Display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Display_CellContentClick);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(297, 270);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 10;
            this.load.Text = "Search";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 514);
            this.Controls.Add(this.load);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemcodef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteItemCode);
            this.Controls.Add(this.label1);
            this.Name = "DeleteItem";
            this.Text = "DeleteItem";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteItemCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemcodef;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Display;
        private System.Windows.Forms.Button load;
    }
}