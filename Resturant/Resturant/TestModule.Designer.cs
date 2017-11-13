namespace Resturant
{
    partial class TestModule
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
            this.DineIn = new System.Windows.Forms.Button();
            this.CustomerManagement = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DineIn
            // 
            this.DineIn.Location = new System.Drawing.Point(34, 40);
            this.DineIn.Name = "DineIn";
            this.DineIn.Size = new System.Drawing.Size(348, 112);
            this.DineIn.TabIndex = 0;
            this.DineIn.Text = "Dine In";
            this.DineIn.UseVisualStyleBackColor = true;
            this.DineIn.Click += new System.EventHandler(this.DineIn_Click);
            // 
            // CustomerManagement
            // 
            this.CustomerManagement.Location = new System.Drawing.Point(505, 36);
            this.CustomerManagement.Name = "CustomerManagement";
            this.CustomerManagement.Size = new System.Drawing.Size(244, 116);
            this.CustomerManagement.TabIndex = 1;
            this.CustomerManagement.Text = "Customer Management";
            this.CustomerManagement.UseVisualStyleBackColor = true;
            this.CustomerManagement.Click += new System.EventHandler(this.CustomerManagement_Click);
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(822, 23);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(188, 129);
            this.Event.TabIndex = 2;
            this.Event.Text = "Event";
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Event);
            this.Controls.Add(this.CustomerManagement);
            this.Controls.Add(this.DineIn);
            this.Name = "TestModule";
            this.Text = "TestModule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DineIn;
        private System.Windows.Forms.Button CustomerManagement;
        private System.Windows.Forms.Button Event;
        private System.Windows.Forms.Button button1;
    }
}