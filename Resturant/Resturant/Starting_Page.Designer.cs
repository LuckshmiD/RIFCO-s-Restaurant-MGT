﻿namespace Resturant
{
    partial class Starting_Page
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
            this.dinein = new System.Windows.Forms.Button();
            this.delivery = new System.Windows.Forms.Button();
            this.takeaway = new System.Windows.Forms.Button();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dinein
            // 
            this.dinein.Location = new System.Drawing.Point(12, 12);
            this.dinein.Name = "dinein";
            this.dinein.Size = new System.Drawing.Size(109, 41);
            this.dinein.TabIndex = 0;
            this.dinein.Text = "Dine In";
            this.dinein.UseVisualStyleBackColor = true;
            this.dinein.Click += new System.EventHandler(this.dinein_Click);
            // 
            // delivery
            // 
            this.delivery.Location = new System.Drawing.Point(12, 59);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(109, 41);
            this.delivery.TabIndex = 1;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.Click += new System.EventHandler(this.delivery_Click);
            // 
            // takeaway
            // 
            this.takeaway.Location = new System.Drawing.Point(12, 106);
            this.takeaway.Name = "takeaway";
            this.takeaway.Size = new System.Drawing.Size(109, 41);
            this.takeaway.TabIndex = 2;
            this.takeaway.Text = "Take Away";
            this.takeaway.UseVisualStyleBackColor = true;
            this.takeaway.Click += new System.EventHandler(this.takeaway_Click);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(138, 26);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(53, 13);
            this.TableLabel.TabIndex = 3;
            this.TableLabel.Text = "Table # : ";
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.TableComboBox.Location = new System.Drawing.Point(197, 23);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(29, 21);
            this.TableComboBox.TabIndex = 4;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(306, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(101, 70);
            this.login.TabIndex = 5;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Starting_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 174);
            this.Controls.Add(this.login);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.takeaway);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.dinein);
            this.Name = "Starting_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting_Page";
            this.Load += new System.EventHandler(this.Starting_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dinein;
        private System.Windows.Forms.Button delivery;
        private System.Windows.Forms.Button takeaway;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.Button login;
    }
}