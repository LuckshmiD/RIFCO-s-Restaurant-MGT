namespace Cashier
{
    partial class TableView
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.Button();
            this.CreditCard = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Cash
            // 
            this.Cash.BackgroundImage = global::Resturant.Properties.Resources.cash;
            this.Cash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cash.FlatAppearance.BorderSize = 0;
            this.Cash.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cash.Location = new System.Drawing.Point(837, 83);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(142, 144);
            this.Cash.TabIndex = 3;
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            this.Cash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cash_MouseDown);
            this.Cash.MouseLeave += new System.EventHandler(this.Cash_MouseLeave);
            this.Cash.MouseHover += new System.EventHandler(this.Cash_MouseHover);
            this.Cash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Cash_MouseMove);
            this.Cash.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Cash_MouseUp);
            // 
            // CreditCard
            // 
            this.CreditCard.BackgroundImage = global::Resturant.Properties.Resources.credit;
            this.CreditCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreditCard.FlatAppearance.BorderSize = 0;
            this.CreditCard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditCard.Location = new System.Drawing.Point(837, 261);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(142, 144);
            this.CreditCard.TabIndex = 4;
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            this.CreditCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreditCard_MouseDown);
            this.CreditCard.MouseLeave += new System.EventHandler(this.CreditCard_MouseLeave);
            this.CreditCard.MouseHover += new System.EventHandler(this.CreditCard_MouseHover);
            this.CreditCard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CreditCard_MouseMove);
            this.CreditCard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CreditCard_MouseUp);
            // 
            // close
            // 
            this.close.BackgroundImage = global::Resturant.Properties.Resources.error__1_;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1022, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 48);
            this.close.TabIndex = 5;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.close.MouseHover += new System.EventHandler(this.close_MouseHover);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1094, 487);
            this.Controls.Add(this.close);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.Button CreditCard;
        private System.Windows.Forms.Button close;
    }
}