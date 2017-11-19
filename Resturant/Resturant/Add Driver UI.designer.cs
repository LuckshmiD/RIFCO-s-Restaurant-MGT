namespace Transport
{
    partial class Add_Driver_UI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idIn = new System.Windows.Forms.TextBox();
            this.plateIn = new System.Windows.Forms.TextBox();
            this.addressIn = new System.Windows.Forms.TextBox();
            this.nameIn = new System.Windows.Forms.TextBox();
            this.numbIn = new System.Windows.Forms.TextBox();
            this.licNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_delete = new System.Windows.Forms.DataGridView();
            this.button_Tdelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delete)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assingned Plate Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Driver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // idIn
            // 
            this.idIn.Location = new System.Drawing.Point(226, 24);
            this.idIn.Name = "idIn";
            this.idIn.Size = new System.Drawing.Size(143, 22);
            this.idIn.TabIndex = 6;
            // 
            // plateIn
            // 
            this.plateIn.Location = new System.Drawing.Point(226, 287);
            this.plateIn.Name = "plateIn";
            this.plateIn.Size = new System.Drawing.Size(143, 22);
            this.plateIn.TabIndex = 7;
            // 
            // addressIn
            // 
            this.addressIn.Location = new System.Drawing.Point(226, 159);
            this.addressIn.Multiline = true;
            this.addressIn.Name = "addressIn";
            this.addressIn.Size = new System.Drawing.Size(143, 46);
            this.addressIn.TabIndex = 8;
            // 
            // nameIn
            // 
            this.nameIn.Location = new System.Drawing.Point(226, 59);
            this.nameIn.Name = "nameIn";
            this.nameIn.Size = new System.Drawing.Size(143, 22);
            this.nameIn.TabIndex = 9;
            // 
            // numbIn
            // 
            this.numbIn.Location = new System.Drawing.Point(226, 228);
            this.numbIn.Name = "numbIn";
            this.numbIn.Size = new System.Drawing.Size(143, 22);
            this.numbIn.TabIndex = 10;
            // 
            // licNo
            // 
            this.licNo.Location = new System.Drawing.Point(226, 106);
            this.licNo.Name = "licNo";
            this.licNo.Size = new System.Drawing.Size(143, 22);
            this.licNo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "License Number";
            // 
            // dgv_delete
            // 
            this.dgv_delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_delete.Location = new System.Drawing.Point(375, 12);
            this.dgv_delete.Name = "dgv_delete";
            this.dgv_delete.RowHeadersVisible = false;
            this.dgv_delete.RowTemplate.Height = 24;
            this.dgv_delete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_delete.Size = new System.Drawing.Size(507, 495);
            this.dgv_delete.TabIndex = 13;
            this.dgv_delete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_delete_MouseClick);
            this.dgv_delete.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_delete_CellMouseUp);
            this.dgv_delete.Click += new System.EventHandler(this.dgv_delete_Click);
            // 
            // button_Tdelete
            // 
            this.button_Tdelete.Location = new System.Drawing.Point(239, 384);
            this.button_Tdelete.Name = "button_Tdelete";
            this.button_Tdelete.Size = new System.Drawing.Size(97, 54);
            this.button_Tdelete.TabIndex = 14;
            this.button_Tdelete.Text = "Delete";
            this.button_Tdelete.UseVisualStyleBackColor = true;
            this.button_Tdelete.Click += new System.EventHandler(this.button_Tdelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 28);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(131, 384);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 54);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Add_Driver_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 519);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button_Tdelete);
            this.Controls.Add(this.dgv_delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.licNo);
            this.Controls.Add(this.numbIn);
            this.Controls.Add(this.nameIn);
            this.Controls.Add(this.addressIn);
            this.Controls.Add(this.plateIn);
            this.Controls.Add(this.idIn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add_Driver_UI";
            this.Text = "Add_Driver_UI";
            this.Load += new System.EventHandler(this.Add_Driver_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delete)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idIn;
        private System.Windows.Forms.TextBox plateIn;
        private System.Windows.Forms.TextBox addressIn;
        private System.Windows.Forms.TextBox nameIn;
        private System.Windows.Forms.TextBox numbIn;
        private System.Windows.Forms.TextBox licNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_delete;
        private System.Windows.Forms.Button button_Tdelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.Button updateButton;
    }
}