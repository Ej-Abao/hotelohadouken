namespace ReservationUI
{
    partial class ReservationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.CheckIN = new System.Windows.Forms.DateTimePicker();
            this.CheckOUT = new System.Windows.Forms.DateTimePicker();
            this.ReserveBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.EditBTN = new System.Windows.Forms.Button();
            this.RefreshBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Details:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(377, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 445);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(370, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Reservations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PeachPuff;
            this.label4.Location = new System.Drawing.Point(46, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Full Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PeachPuff;
            this.label5.Location = new System.Drawing.Point(46, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 40);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PeachPuff;
            this.label6.Location = new System.Drawing.Point(46, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Check In:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PeachPuff;
            this.label7.Location = new System.Drawing.Point(46, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 40);
            this.label7.TabIndex = 7;
            this.label7.Text = "Check Out:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PeachPuff;
            this.label8.Location = new System.Drawing.Point(51, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 40);
            this.label8.TabIndex = 8;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PeachPuff;
            this.label9.Location = new System.Drawing.Point(51, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 40);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Price:";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(232, 150);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(121, 22);
            this.FullName.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Status.Cursor = System.Windows.Forms.Cursors.No;
            this.Status.ForeColor = System.Drawing.Color.PeachPuff;
            this.Status.Location = new System.Drawing.Point(232, 310);
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(121, 15);
            this.Status.TabIndex = 12;
            this.Status.Text = "...";
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPrice.ForeColor = System.Drawing.Color.PeachPuff;
            this.TotalPrice.Location = new System.Drawing.Point(232, 350);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(121, 15);
            this.TotalPrice.TabIndex = 13;
            this.TotalPrice.Text = "...";
            // 
            // RoomType
            // 
            this.RoomType.FormattingEnabled = true;
            this.RoomType.Location = new System.Drawing.Point(232, 190);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(121, 24);
            this.RoomType.TabIndex = 14;
            // 
            // CheckIN
            // 
            this.CheckIN.Location = new System.Drawing.Point(232, 228);
            this.CheckIN.Name = "CheckIN";
            this.CheckIN.Size = new System.Drawing.Size(121, 22);
            this.CheckIN.TabIndex = 15;
            // 
            // CheckOUT
            // 
            this.CheckOUT.Location = new System.Drawing.Point(232, 268);
            this.CheckOUT.Name = "CheckOUT";
            this.CheckOUT.Size = new System.Drawing.Size(121, 22);
            this.CheckOUT.TabIndex = 16;
            // 
            // ReserveBTN
            // 
            this.ReserveBTN.BackColor = System.Drawing.Color.Maroon;
            this.ReserveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBTN.ForeColor = System.Drawing.Color.PeachPuff;
            this.ReserveBTN.Location = new System.Drawing.Point(278, 402);
            this.ReserveBTN.Name = "ReserveBTN";
            this.ReserveBTN.Size = new System.Drawing.Size(75, 23);
            this.ReserveBTN.TabIndex = 17;
            this.ReserveBTN.Text = "Reserve!";
            this.ReserveBTN.UseVisualStyleBackColor = false;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.Maroon;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBTN.ForeColor = System.Drawing.Color.PeachPuff;
            this.CancelBTN.Location = new System.Drawing.Point(58, 402);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 18;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = false;
            // 
            // EditBTN
            // 
            this.EditBTN.BackColor = System.Drawing.Color.Maroon;
            this.EditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBTN.ForeColor = System.Drawing.Color.PeachPuff;
            this.EditBTN.Location = new System.Drawing.Point(278, 442);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(75, 23);
            this.EditBTN.TabIndex = 19;
            this.EditBTN.Text = "Edit";
            this.EditBTN.UseVisualStyleBackColor = false;
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.BackColor = System.Drawing.Color.Maroon;
            this.RefreshBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN.ForeColor = System.Drawing.Color.PeachPuff;
            this.RefreshBTN.Location = new System.Drawing.Point(58, 442);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.Size = new System.Drawing.Size(75, 23);
            this.RefreshBTN.TabIndex = 20;
            this.RefreshBTN.Text = "Refresh";
            this.RefreshBTN.UseVisualStyleBackColor = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.RefreshBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ReserveBTN);
            this.Controls.Add(this.CheckOUT);
            this.Controls.Add(this.CheckIN);
            this.Controls.Add(this.RoomType);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.DateTimePicker CheckIN;
        private System.Windows.Forms.DateTimePicker CheckOUT;
        private System.Windows.Forms.Button ReserveBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Button EditBTN;
        private System.Windows.Forms.Button RefreshBTN;
    }
}

