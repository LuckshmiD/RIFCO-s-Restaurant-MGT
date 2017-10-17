namespace Cashier
{
    partial class DeliveryPayment
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
            this.cash = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // cash
            // 
            this.cash.BackgroundImage = global::Resturant.Properties.Resources.cash;
            this.cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cash.FlatAppearance.BorderSize = 0;
            this.cash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cash.Location = new System.Drawing.Point(12, 651);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(173, 163);
            this.cash.TabIndex = 1;
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            this.cash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cash_MouseDown);
            this.cash.MouseLeave += new System.EventHandler(this.cash_MouseLeave);
            this.cash.MouseHover += new System.EventHandler(this.cash_MouseHover);
            this.cash.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cash_MouseUp);
            // 
            // credit
            // 
            this.credit.BackgroundImage = global::Resturant.Properties.Resources.credit;
            this.credit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.credit.FlatAppearance.BorderSize = 0;
            this.credit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.credit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credit.Location = new System.Drawing.Point(791, 651);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(173, 163);
            this.credit.TabIndex = 2;
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            this.credit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.credit_MouseDown);
            this.credit.MouseLeave += new System.EventHandler(this.credit_MouseLeave);
            this.credit.MouseHover += new System.EventHandler(this.credit_MouseHover);
            this.credit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.credit_MouseUp);
            // 
            // close
            // 
            this.close.BackgroundImage = global::Resturant.Properties.Resources.error__1_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(891, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(73, 72);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.close_MouseDown);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            this.close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.close_MouseUp);
            // 
            // DeliveryPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 826);
            this.Controls.Add(this.close);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliveryPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.Button close;
    }
}