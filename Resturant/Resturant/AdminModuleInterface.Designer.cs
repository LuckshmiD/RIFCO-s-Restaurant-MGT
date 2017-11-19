namespace Resturant
{
    partial class AdminModuleInterface
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
            this.cashier = new System.Windows.Forms.Button();
            this.hrman = new System.Windows.Forms.Button();
            this.eventmgt = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.finance = new System.Windows.Forms.Button();
            this.addDriver = new System.Windows.Forms.Button();
            this.driAvail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashier
            // 
            this.cashier.Location = new System.Drawing.Point(10, 35);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(94, 49);
            this.cashier.TabIndex = 0;
            this.cashier.Text = "Cashier";
            this.cashier.UseVisualStyleBackColor = true;
            this.cashier.Click += new System.EventHandler(this.cashier_Click);
            // 
            // hrman
            // 
            this.hrman.Location = new System.Drawing.Point(110, 35);
            this.hrman.Name = "hrman";
            this.hrman.Size = new System.Drawing.Size(94, 49);
            this.hrman.TabIndex = 1;
            this.hrman.Text = "H.R.Mgt";
            this.hrman.UseVisualStyleBackColor = true;
            this.hrman.Click += new System.EventHandler(this.hrman_Click);
            // 
            // eventmgt
            // 
            this.eventmgt.Location = new System.Drawing.Point(210, 35);
            this.eventmgt.Name = "eventmgt";
            this.eventmgt.Size = new System.Drawing.Size(94, 49);
            this.eventmgt.TabIndex = 2;
            this.eventmgt.Text = "Event, Cater";
            this.eventmgt.UseVisualStyleBackColor = true;
            this.eventmgt.Click += new System.EventHandler(this.eventmgt_Click);
            // 
            // supplier
            // 
            this.supplier.Location = new System.Drawing.Point(310, 35);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(94, 49);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "Supplier";
            this.supplier.UseVisualStyleBackColor = true;
            this.supplier.Click += new System.EventHandler(this.supplier_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(10, 90);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(94, 49);
            this.customer.TabIndex = 4;
            this.customer.Text = "Customer mgt";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // finance
            // 
            this.finance.Location = new System.Drawing.Point(111, 90);
            this.finance.Name = "finance";
            this.finance.Size = new System.Drawing.Size(93, 48);
            this.finance.TabIndex = 5;
            this.finance.Text = "Finance";
            this.finance.UseVisualStyleBackColor = true;
            this.finance.Click += new System.EventHandler(this.finance_Click);
            // 
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(211, 91);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(93, 47);
            this.addDriver.TabIndex = 6;
            this.addDriver.Text = "Add Driver";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // driAvail
            // 
            this.driAvail.Location = new System.Drawing.Point(311, 91);
            this.driAvail.Name = "driAvail";
            this.driAvail.Size = new System.Drawing.Size(93, 47);
            this.driAvail.TabIndex = 7;
            this.driAvail.Text = "Driver Availability";
            this.driAvail.UseVisualStyleBackColor = true;
            this.driAvail.Click += new System.EventHandler(this.driAvail_Click);
            // 
            // AdminModuleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 177);
            this.Controls.Add(this.driAvail);
            this.Controls.Add(this.addDriver);
            this.Controls.Add(this.finance);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.eventmgt);
            this.Controls.Add(this.hrman);
            this.Controls.Add(this.cashier);
            this.Name = "AdminModuleInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminModuleInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cashier;
        private System.Windows.Forms.Button hrman;
        private System.Windows.Forms.Button eventmgt;
        private System.Windows.Forms.Button supplier;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button finance;
        private System.Windows.Forms.Button addDriver;
        private System.Windows.Forms.Button driAvail;
    }
}