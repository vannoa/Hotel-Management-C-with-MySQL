namespace Hotel
{
    partial class Reservation_Page
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
            this.lbladdreservationclient = new System.Windows.Forms.Button();
            this.btnclearfieldreservpage = new System.Windows.Forms.Button();
            this.dtdateout = new System.Windows.Forms.DateTimePicker();
            this.dtdatein = new System.Windows.Forms.DateTimePicker();
            this.cbxroomtypereserv = new System.Windows.Forms.ComboBox();
            this.tbxclientidreserv = new System.Windows.Forms.TextBox();
            this.tbxreservationidclient = new System.Windows.Forms.TextBox();
            this.lbldateoutreserv = new System.Windows.Forms.Label();
            this.lbldateinreserv = new System.Windows.Forms.Label();
            this.lblnoroomreserv = new System.Windows.Forms.Label();
            this.lblroomtypereserv = new System.Windows.Forms.Label();
            this.lblclientidreserv = new System.Windows.Forms.Label();
            this.lblreservidreserv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxroompricereserv = new System.Windows.Forms.TextBox();
            this.lblroompricereserv = new System.Windows.Forms.Label();
            this.tbxnoroomreserv = new System.Windows.Forms.TextBox();
            this.btnbillingpayment = new System.Windows.Forms.Button();
            this.btnmenureserv = new System.Windows.Forms.Button();
            this.cbxcarabayarreserv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtbookingdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbladdreservationclient
            // 
            this.lbladdreservationclient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbladdreservationclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbladdreservationclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdreservationclient.Location = new System.Drawing.Point(16, 548);
            this.lbladdreservationclient.Margin = new System.Windows.Forms.Padding(2);
            this.lbladdreservationclient.Name = "lbladdreservationclient";
            this.lbladdreservationclient.Size = new System.Drawing.Size(179, 54);
            this.lbladdreservationclient.TabIndex = 45;
            this.lbladdreservationclient.Text = "Add Reservation";
            this.lbladdreservationclient.UseVisualStyleBackColor = false;
            this.lbladdreservationclient.Click += new System.EventHandler(this.Lbladdreservationclient_Click);
            // 
            // btnclearfieldreservpage
            // 
            this.btnclearfieldreservpage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclearfieldreservpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclearfieldreservpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearfieldreservpage.Location = new System.Drawing.Point(212, 548);
            this.btnclearfieldreservpage.Margin = new System.Windows.Forms.Padding(2);
            this.btnclearfieldreservpage.Name = "btnclearfieldreservpage";
            this.btnclearfieldreservpage.Size = new System.Drawing.Size(138, 54);
            this.btnclearfieldreservpage.TabIndex = 44;
            this.btnclearfieldreservpage.Text = "Clear Fields";
            this.btnclearfieldreservpage.UseVisualStyleBackColor = false;
            this.btnclearfieldreservpage.Click += new System.EventHandler(this.Btnclearfieldreservpage_Click);
            // 
            // dtdateout
            // 
            this.dtdateout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdateout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdateout.Location = new System.Drawing.Point(150, 434);
            this.dtdateout.Margin = new System.Windows.Forms.Padding(2);
            this.dtdateout.Name = "dtdateout";
            this.dtdateout.Size = new System.Drawing.Size(200, 30);
            this.dtdateout.TabIndex = 43;
            this.dtdateout.ValueChanged += new System.EventHandler(this.Dtdateout_ValueChanged);
            // 
            // dtdatein
            // 
            this.dtdatein.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdatein.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdatein.Location = new System.Drawing.Point(150, 391);
            this.dtdatein.Margin = new System.Windows.Forms.Padding(2);
            this.dtdatein.Name = "dtdatein";
            this.dtdatein.Size = new System.Drawing.Size(200, 30);
            this.dtdatein.TabIndex = 42;
            this.dtdatein.ValueChanged += new System.EventHandler(this.Dtdatein_ValueChanged);
            // 
            // cbxroomtypereserv
            // 
            this.cbxroomtypereserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxroomtypereserv.IntegralHeight = false;
            this.cbxroomtypereserv.Location = new System.Drawing.Point(150, 212);
            this.cbxroomtypereserv.Margin = new System.Windows.Forms.Padding(2);
            this.cbxroomtypereserv.Name = "cbxroomtypereserv";
            this.cbxroomtypereserv.Size = new System.Drawing.Size(200, 33);
            this.cbxroomtypereserv.TabIndex = 40;
            this.cbxroomtypereserv.SelectedIndexChanged += new System.EventHandler(this.Cbxroomtypereserv_SelectedIndexChanged);
            // 
            // tbxclientidreserv
            // 
            this.tbxclientidreserv.Enabled = false;
            this.tbxclientidreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxclientidreserv.Location = new System.Drawing.Point(150, 164);
            this.tbxclientidreserv.Margin = new System.Windows.Forms.Padding(2);
            this.tbxclientidreserv.Multiline = true;
            this.tbxclientidreserv.Name = "tbxclientidreserv";
            this.tbxclientidreserv.Size = new System.Drawing.Size(200, 32);
            this.tbxclientidreserv.TabIndex = 39;
            // 
            // tbxreservationidclient
            // 
            this.tbxreservationidclient.Enabled = false;
            this.tbxreservationidclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxreservationidclient.Location = new System.Drawing.Point(150, 112);
            this.tbxreservationidclient.Margin = new System.Windows.Forms.Padding(2);
            this.tbxreservationidclient.Multiline = true;
            this.tbxreservationidclient.Name = "tbxreservationidclient";
            this.tbxreservationidclient.Size = new System.Drawing.Size(200, 32);
            this.tbxreservationidclient.TabIndex = 38;
            // 
            // lbldateoutreserv
            // 
            this.lbldateoutreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateoutreserv.Location = new System.Drawing.Point(15, 431);
            this.lbldateoutreserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldateoutreserv.Name = "lbldateoutreserv";
            this.lbldateoutreserv.Size = new System.Drawing.Size(130, 32);
            this.lbldateoutreserv.TabIndex = 37;
            this.lbldateoutreserv.Text = "Date OUT";
            this.lbldateoutreserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbldateinreserv
            // 
            this.lbldateinreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateinreserv.Location = new System.Drawing.Point(15, 389);
            this.lbldateinreserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldateinreserv.Name = "lbldateinreserv";
            this.lbldateinreserv.Size = new System.Drawing.Size(130, 32);
            this.lbldateinreserv.TabIndex = 36;
            this.lbldateinreserv.Text = "Date IN";
            this.lbldateinreserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnoroomreserv
            // 
            this.lblnoroomreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoroomreserv.Location = new System.Drawing.Point(2, 298);
            this.lblnoroomreserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoroomreserv.Name = "lblnoroomreserv";
            this.lblnoroomreserv.Size = new System.Drawing.Size(143, 32);
            this.lblnoroomreserv.TabIndex = 35;
            this.lblnoroomreserv.Text = "Jml. Room";
            this.lblnoroomreserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblroomtypereserv
            // 
            this.lblroomtypereserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtypereserv.Location = new System.Drawing.Point(2, 210);
            this.lblroomtypereserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroomtypereserv.Name = "lblroomtypereserv";
            this.lblroomtypereserv.Size = new System.Drawing.Size(143, 32);
            this.lblroomtypereserv.TabIndex = 34;
            this.lblroomtypereserv.Text = "Room Type";
            this.lblroomtypereserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblclientidreserv
            // 
            this.lblclientidreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientidreserv.Location = new System.Drawing.Point(15, 161);
            this.lblclientidreserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclientidreserv.Name = "lblclientidreserv";
            this.lblclientidreserv.Size = new System.Drawing.Size(130, 32);
            this.lblclientidreserv.TabIndex = 33;
            this.lblclientidreserv.Text = "Client ID";
            this.lblclientidreserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblclientidreserv.Click += new System.EventHandler(this.Lblclientidreserv_Click);
            // 
            // lblreservidreserv
            // 
            this.lblreservidreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreservidreserv.Location = new System.Drawing.Point(15, 112);
            this.lblreservidreserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreservidreserv.Name = "lblreservidreserv";
            this.lblreservidreserv.Size = new System.Drawing.Size(130, 32);
            this.lblreservidreserv.TabIndex = 32;
            this.lblreservidreserv.Text = "Reserv. ID";
            this.lblreservidreserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 69);
            this.label1.TabIndex = 31;
            this.label1.Text = "Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxroompricereserv
            // 
            this.tbxroompricereserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxroompricereserv.Location = new System.Drawing.Point(150, 249);
            this.tbxroompricereserv.Margin = new System.Windows.Forms.Padding(2);
            this.tbxroompricereserv.Multiline = true;
            this.tbxroompricereserv.Name = "tbxroompricereserv";
            this.tbxroompricereserv.Size = new System.Drawing.Size(200, 32);
            this.tbxroompricereserv.TabIndex = 48;
            // 
            // lblroompricereserv
            // 
            this.lblroompricereserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroompricereserv.Location = new System.Drawing.Point(3, 249);
            this.lblroompricereserv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblroompricereserv.Name = "lblroompricereserv";
            this.lblroompricereserv.Size = new System.Drawing.Size(143, 32);
            this.lblroompricereserv.TabIndex = 49;
            this.lblroompricereserv.Text = "Rm. Price";
            this.lblroompricereserv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxnoroomreserv
            // 
            this.tbxnoroomreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnoroomreserv.Location = new System.Drawing.Point(150, 300);
            this.tbxnoroomreserv.Margin = new System.Windows.Forms.Padding(2);
            this.tbxnoroomreserv.Multiline = true;
            this.tbxnoroomreserv.Name = "tbxnoroomreserv";
            this.tbxnoroomreserv.Size = new System.Drawing.Size(200, 32);
            this.tbxnoroomreserv.TabIndex = 50;
            // 
            // btnbillingpayment
            // 
            this.btnbillingpayment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbillingpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbillingpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillingpayment.Location = new System.Drawing.Point(16, 606);
            this.btnbillingpayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnbillingpayment.Name = "btnbillingpayment";
            this.btnbillingpayment.Size = new System.Drawing.Size(334, 54);
            this.btnbillingpayment.TabIndex = 53;
            this.btnbillingpayment.Text = "Billing and Payment";
            this.btnbillingpayment.UseVisualStyleBackColor = false;
            this.btnbillingpayment.Click += new System.EventHandler(this.Btnbillingpayment_Click);
            // 
            // btnmenureserv
            // 
            this.btnmenureserv.Location = new System.Drawing.Point(275, 71);
            this.btnmenureserv.Name = "btnmenureserv";
            this.btnmenureserv.Size = new System.Drawing.Size(75, 23);
            this.btnmenureserv.TabIndex = 54;
            this.btnmenureserv.Text = "Menu";
            this.btnmenureserv.UseVisualStyleBackColor = true;
            this.btnmenureserv.Click += new System.EventHandler(this.Btnmenureserv_Click);
            // 
            // cbxcarabayarreserv
            // 
            this.cbxcarabayarreserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxcarabayarreserv.IntegralHeight = false;
            this.cbxcarabayarreserv.Items.AddRange(new object[] {
            "Transfer",
            "Kredit",
            "Cash",
            "Flazz"});
            this.cbxcarabayarreserv.Location = new System.Drawing.Point(150, 479);
            this.cbxcarabayarreserv.Margin = new System.Windows.Forms.Padding(2);
            this.cbxcarabayarreserv.Name = "cbxcarabayarreserv";
            this.cbxcarabayarreserv.Size = new System.Drawing.Size(200, 33);
            this.cbxcarabayarreserv.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 477);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 56;
            this.label2.Text = "Cara Bayar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 61;
            this.label3.Text = "Booking Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtbookingdate
            // 
            this.dtbookingdate.Enabled = false;
            this.dtbookingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbookingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbookingdate.Location = new System.Drawing.Point(150, 347);
            this.dtbookingdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtbookingdate.Name = "dtbookingdate";
            this.dtbookingdate.Size = new System.Drawing.Size(200, 30);
            this.dtbookingdate.TabIndex = 62;
            // 
            // Reservation_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(361, 673);
            this.Controls.Add(this.dtbookingdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxcarabayarreserv);
            this.Controls.Add(this.btnmenureserv);
            this.Controls.Add(this.btnbillingpayment);
            this.Controls.Add(this.tbxnoroomreserv);
            this.Controls.Add(this.lblroompricereserv);
            this.Controls.Add(this.tbxroompricereserv);
            this.Controls.Add(this.lbladdreservationclient);
            this.Controls.Add(this.btnclearfieldreservpage);
            this.Controls.Add(this.dtdateout);
            this.Controls.Add(this.dtdatein);
            this.Controls.Add(this.cbxroomtypereserv);
            this.Controls.Add(this.tbxclientidreserv);
            this.Controls.Add(this.tbxreservationidclient);
            this.Controls.Add(this.lbldateoutreserv);
            this.Controls.Add(this.lbldateinreserv);
            this.Controls.Add(this.lblnoroomreserv);
            this.Controls.Add(this.lblroomtypereserv);
            this.Controls.Add(this.lblclientidreserv);
            this.Controls.Add(this.lblreservidreserv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reservation_Page";
            this.Text = "Reservation_Page";
            this.Load += new System.EventHandler(this.Reservation_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button lbladdreservationclient;
        private System.Windows.Forms.Button btnclearfieldreservpage;
        private System.Windows.Forms.DateTimePicker dtdateout;
        private System.Windows.Forms.DateTimePicker dtdatein;
        private System.Windows.Forms.ComboBox cbxroomtypereserv;
        private System.Windows.Forms.TextBox tbxclientidreserv;
        private System.Windows.Forms.TextBox tbxreservationidclient;
        private System.Windows.Forms.Label lbldateoutreserv;
        private System.Windows.Forms.Label lbldateinreserv;
        private System.Windows.Forms.Label lblnoroomreserv;
        private System.Windows.Forms.Label lblroomtypereserv;
        private System.Windows.Forms.Label lblclientidreserv;
        private System.Windows.Forms.Label lblreservidreserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxroompricereserv;
        private System.Windows.Forms.Label lblroompricereserv;
        private System.Windows.Forms.TextBox tbxnoroomreserv;
        private System.Windows.Forms.Button btnbillingpayment;
        private System.Windows.Forms.Button btnmenureserv;
        private System.Windows.Forms.ComboBox cbxcarabayarreserv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtbookingdate;
    }
}