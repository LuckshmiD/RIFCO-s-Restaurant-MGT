namespace Transport
{
    partial class Transport_management
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
            this.addDriver = new System.Windows.Forms.Button();
            this.deleteDriver = new System.Windows.Forms.Button();
            this.editDriver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(108, 123);
            this.addDriver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(184, 181);
            this.addDriver.TabIndex = 0;
            this.addDriver.Text = "Driver Details Management";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteDriver
            // 
            this.deleteDriver.Location = new System.Drawing.Point(279, 462);
            this.deleteDriver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteDriver.Name = "deleteDriver";
            this.deleteDriver.Size = new System.Drawing.Size(148, 63);
            this.deleteDriver.TabIndex = 1;
            this.deleteDriver.Text = "Delete Driver details";
            this.deleteDriver.UseVisualStyleBackColor = true;
            this.deleteDriver.Visible = false;
            this.deleteDriver.Click += new System.EventHandler(this.deleteDriver_Click);
            // 
            // editDriver
            // 
            this.editDriver.Location = new System.Drawing.Point(454, 472);
            this.editDriver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editDriver.Name = "editDriver";
            this.editDriver.Size = new System.Drawing.Size(148, 50);
            this.editDriver.TabIndex = 2;
            this.editDriver.Text = "Edit Driver details";
            this.editDriver.UseVisualStyleBackColor = true;
            this.editDriver.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 181);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Vehicle Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 458);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Vehicle details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Transport_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(808, 531);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editDriver);
            this.Controls.Add(this.deleteDriver);
            this.Controls.Add(this.addDriver);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Transport_management";
            this.Text = "Transport management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDriver;
        private System.Windows.Forms.Button deleteDriver;
        private System.Windows.Forms.Button editDriver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

