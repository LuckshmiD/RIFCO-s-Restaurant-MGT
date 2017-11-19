namespace Cashier
{
    partial class ConfirmPayment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.confirmPay = new System.Windows.Forms.Button();
            this.deliveryFee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(602, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(243, 422);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(113, 26);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Total Price : ";
            // 
            // back
            // 
            this.back.BackgroundImage = global::Resturant.Properties.Resources.error__1_;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(9, 482);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 69);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            this.back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_MouseDown);
            this.back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            this.back.MouseHover += new System.EventHandler(this.back_MouseHover);
            this.back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_MouseUp);
            // 
            // confirmPay
            // 
            this.confirmPay.BackgroundImage = global::Resturant.Properties.Resources.success__1_;
            this.confirmPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmPay.FlatAppearance.BorderSize = 0;
            this.confirmPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmPay.Location = new System.Drawing.Point(546, 482);
            this.confirmPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPay.Name = "confirmPay";
            this.confirmPay.Size = new System.Drawing.Size(64, 69);
            this.confirmPay.TabIndex = 3;
            this.confirmPay.UseVisualStyleBackColor = true;
            this.confirmPay.Click += new System.EventHandler(this.confirmPay_Click);
            this.confirmPay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.confirmPay_MouseDown);
            this.confirmPay.MouseLeave += new System.EventHandler(this.confirmPay_MouseLeave);
            this.confirmPay.MouseHover += new System.EventHandler(this.confirmPay_MouseHover);
            this.confirmPay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.confirmPay_MouseUp);
            // 
            // deliveryFee
            // 
            this.deliveryFee.AutoSize = true;
            this.deliveryFee.Location = new System.Drawing.Point(272, 462);
            this.deliveryFee.Name = "deliveryFee";
            this.deliveryFee.Size = new System.Drawing.Size(75, 13);
            this.deliveryFee.TabIndex = 4;
            this.deliveryFee.Text = "Delivery Fee : ";
            this.deliveryFee.Visible = false;
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 561);
            this.Controls.Add(this.deliveryFee);
            this.Controls.Add(this.confirmPay);
            this.Controls.Add(this.back);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConfirmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmPayment";
            this.Load += new System.EventHandler(this.ConfirmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button confirmPay;
        private System.Windows.Forms.Label deliveryFee;
    }
}