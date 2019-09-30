namespace Hotel
{
    partial class Menu
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
            this.btnmanageclientmenu = new System.Windows.Forms.Button();
            this.btnmanageroommenu = new System.Windows.Forms.Button();
            this.btnmanagereservationmenu = new System.Windows.Forms.Button();
            this.btncheckinmenu = new System.Windows.Forms.Button();
            this.btnlogoutadmin = new System.Windows.Forms.Button();
            this.btncheckoutmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmanageclientmenu
            // 
            this.btnmanageclientmenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmanageclientmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanageclientmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageclientmenu.Location = new System.Drawing.Point(11, 110);
            this.btnmanageclientmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmanageclientmenu.Name = "btnmanageclientmenu";
            this.btnmanageclientmenu.Size = new System.Drawing.Size(334, 54);
            this.btnmanageclientmenu.TabIndex = 28;
            this.btnmanageclientmenu.Text = "Manage Clients";
            this.btnmanageclientmenu.UseVisualStyleBackColor = false;
            this.btnmanageclientmenu.Click += new System.EventHandler(this.Btnmanageclientmenu_Click);
            // 
            // btnmanageroommenu
            // 
            this.btnmanageroommenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmanageroommenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanageroommenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanageroommenu.Location = new System.Drawing.Point(11, 182);
            this.btnmanageroommenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmanageroommenu.Name = "btnmanageroommenu";
            this.btnmanageroommenu.Size = new System.Drawing.Size(334, 54);
            this.btnmanageroommenu.TabIndex = 29;
            this.btnmanageroommenu.Text = "Manage Rooms";
            this.btnmanageroommenu.UseVisualStyleBackColor = false;
            this.btnmanageroommenu.Click += new System.EventHandler(this.Btnmanageroommenu_Click);
            // 
            // btnmanagereservationmenu
            // 
            this.btnmanagereservationmenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnmanagereservationmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmanagereservationmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanagereservationmenu.Location = new System.Drawing.Point(11, 256);
            this.btnmanagereservationmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnmanagereservationmenu.Name = "btnmanagereservationmenu";
            this.btnmanagereservationmenu.Size = new System.Drawing.Size(334, 54);
            this.btnmanagereservationmenu.TabIndex = 30;
            this.btnmanagereservationmenu.Text = "Manage Reservation";
            this.btnmanagereservationmenu.UseVisualStyleBackColor = false;
            this.btnmanagereservationmenu.Click += new System.EventHandler(this.Btnmanagereservationmenu_Click);
            // 
            // btncheckinmenu
            // 
            this.btncheckinmenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncheckinmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckinmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckinmenu.Location = new System.Drawing.Point(11, 328);
            this.btncheckinmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btncheckinmenu.Name = "btncheckinmenu";
            this.btncheckinmenu.Size = new System.Drawing.Size(334, 54);
            this.btncheckinmenu.TabIndex = 31;
            this.btncheckinmenu.Text = "Check In";
            this.btncheckinmenu.UseVisualStyleBackColor = false;
            this.btncheckinmenu.Click += new System.EventHandler(this.Btncheckinmenu_Click);
            // 
            // btnlogoutadmin
            // 
            this.btnlogoutadmin.Location = new System.Drawing.Point(270, 72);
            this.btnlogoutadmin.Name = "btnlogoutadmin";
            this.btnlogoutadmin.Size = new System.Drawing.Size(75, 23);
            this.btnlogoutadmin.TabIndex = 32;
            this.btnlogoutadmin.Text = "Logout";
            this.btnlogoutadmin.UseVisualStyleBackColor = true;
            this.btnlogoutadmin.Click += new System.EventHandler(this.Btnlogoutadmin_Click);
            // 
            // btncheckoutmenu
            // 
            this.btncheckoutmenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncheckoutmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckoutmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckoutmenu.Location = new System.Drawing.Point(11, 397);
            this.btncheckoutmenu.Margin = new System.Windows.Forms.Padding(2);
            this.btncheckoutmenu.Name = "btncheckoutmenu";
            this.btncheckoutmenu.Size = new System.Drawing.Size(334, 54);
            this.btncheckoutmenu.TabIndex = 33;
            this.btncheckoutmenu.Text = "Check Out";
            this.btncheckoutmenu.UseVisualStyleBackColor = false;
            this.btncheckoutmenu.Click += new System.EventHandler(this.Btncheckoutmenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(358, 460);
            this.Controls.Add(this.btncheckoutmenu);
            this.Controls.Add(this.btnlogoutadmin);
            this.Controls.Add(this.btncheckinmenu);
            this.Controls.Add(this.btnmanagereservationmenu);
            this.Controls.Add(this.btnmanageroommenu);
            this.Controls.Add(this.btnmanageclientmenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmanageclientmenu;
        private System.Windows.Forms.Button btnmanageroommenu;
        private System.Windows.Forms.Button btnmanagereservationmenu;
        private System.Windows.Forms.Button btncheckinmenu;
        private System.Windows.Forms.Button btnlogoutadmin;
        private System.Windows.Forms.Button btncheckoutmenu;
    }
}