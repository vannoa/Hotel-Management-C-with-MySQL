namespace Hotel
{
    partial class Check_In
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
            this.tbxreservationid = new System.Windows.Forms.TextBox();
            this.lblreservationid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenucheckin = new System.Windows.Forms.Button();
            this.btnshowallreservationcheckin = new System.Windows.Forms.Button();
            this.btncheckin = new System.Windows.Forms.Button();
            this.btnsearchreservidcheckin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxdateoutcheckin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxdateincheckin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtcheckincheckin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 402);
            this.dataGridView1.TabIndex = 34;
            // 
            // tbxreservationid
            // 
            this.tbxreservationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxreservationid.Location = new System.Drawing.Point(146, 107);
            this.tbxreservationid.Margin = new System.Windows.Forms.Padding(2);
            this.tbxreservationid.Multiline = true;
            this.tbxreservationid.Name = "tbxreservationid";
            this.tbxreservationid.Size = new System.Drawing.Size(200, 32);
            this.tbxreservationid.TabIndex = 33;
            // 
            // lblreservationid
            // 
            this.lblreservationid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreservationid.Location = new System.Drawing.Point(11, 107);
            this.lblreservationid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreservationid.Name = "lblreservationid";
            this.lblreservationid.Size = new System.Drawing.Size(130, 32);
            this.lblreservationid.TabIndex = 32;
            this.lblreservationid.Text = "Reserv. ID";
            this.lblreservationid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 69);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Check In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmenucheckin
            // 
            this.btnmenucheckin.Location = new System.Drawing.Point(851, 71);
            this.btnmenucheckin.Name = "btnmenucheckin";
            this.btnmenucheckin.Size = new System.Drawing.Size(75, 23);
            this.btnmenucheckin.TabIndex = 36;
            this.btnmenucheckin.Text = "Menu";
            this.btnmenucheckin.UseVisualStyleBackColor = true;
            this.btnmenucheckin.Click += new System.EventHandler(this.Btnmenucheckin_Click);
            // 
            // btnshowallreservationcheckin
            // 
            this.btnshowallreservationcheckin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnshowallreservationcheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowallreservationcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowallreservationcheckin.Location = new System.Drawing.Point(11, 455);
            this.btnshowallreservationcheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btnshowallreservationcheckin.Name = "btnshowallreservationcheckin";
            this.btnshowallreservationcheckin.Size = new System.Drawing.Size(335, 54);
            this.btnshowallreservationcheckin.TabIndex = 37;
            this.btnshowallreservationcheckin.Text = "Show All Reservation";
            this.btnshowallreservationcheckin.UseVisualStyleBackColor = false;
            this.btnshowallreservationcheckin.Click += new System.EventHandler(this.Btnshowallreservationcheckin_Click);
            // 
            // btncheckin
            // 
            this.btncheckin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckin.Location = new System.Drawing.Point(11, 339);
            this.btncheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(335, 54);
            this.btncheckin.TabIndex = 46;
            this.btncheckin.Text = "Check In";
            this.btncheckin.UseVisualStyleBackColor = false;
            this.btncheckin.Click += new System.EventHandler(this.Btncheckin_Click);
            // 
            // btnsearchreservidcheckin
            // 
            this.btnsearchreservidcheckin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearchreservidcheckin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchreservidcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchreservidcheckin.Location = new System.Drawing.Point(11, 397);
            this.btnsearchreservidcheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearchreservidcheckin.Name = "btnsearchreservidcheckin";
            this.btnsearchreservidcheckin.Size = new System.Drawing.Size(335, 54);
            this.btnsearchreservidcheckin.TabIndex = 47;
            this.btnsearchreservidcheckin.Text = "Search Reserv. ID";
            this.btnsearchreservidcheckin.UseVisualStyleBackColor = false;
            this.btnsearchreservidcheckin.Click += new System.EventHandler(this.Btnsearchreservidcheckin_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Check In";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxdateoutcheckin
            // 
            this.tbxdateoutcheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxdateoutcheckin.Location = new System.Drawing.Point(146, 197);
            this.tbxdateoutcheckin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxdateoutcheckin.Multiline = true;
            this.tbxdateoutcheckin.Name = "tbxdateoutcheckin";
            this.tbxdateoutcheckin.Size = new System.Drawing.Size(200, 32);
            this.tbxdateoutcheckin.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Date Out";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxdateincheckin
            // 
            this.tbxdateincheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxdateincheckin.Location = new System.Drawing.Point(146, 151);
            this.tbxdateincheckin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxdateincheckin.Multiline = true;
            this.tbxdateincheckin.Name = "tbxdateincheckin";
            this.tbxdateincheckin.Size = new System.Drawing.Size(200, 32);
            this.tbxdateincheckin.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 52;
            this.label4.Text = "Date In";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtcheckincheckin
            // 
            this.dtcheckincheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcheckincheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtcheckincheckin.Location = new System.Drawing.Point(146, 245);
            this.dtcheckincheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dtcheckincheckin.Name = "dtcheckincheckin";
            this.dtcheckincheckin.Size = new System.Drawing.Size(200, 30);
            this.dtcheckincheckin.TabIndex = 63;
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(938, 557);
            this.Controls.Add(this.dtcheckincheckin);
            this.Controls.Add(this.tbxdateincheckin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxdateoutcheckin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearchreservidcheckin);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.btnshowallreservationcheckin);
            this.Controls.Add(this.btnmenucheckin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxreservationid);
            this.Controls.Add(this.lblreservationid);
            this.Name = "Check_In";
            this.Text = "Check_In";
            this.Load += new System.EventHandler(this.Check_In_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxreservationid;
        private System.Windows.Forms.Label lblreservationid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmenucheckin;
        private System.Windows.Forms.Button btnshowallreservationcheckin;
        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Button btnsearchreservidcheckin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxdateoutcheckin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxdateincheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtcheckincheckin;
    }
}