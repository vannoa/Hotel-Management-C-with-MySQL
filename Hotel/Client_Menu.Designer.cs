namespace Hotel
{
    partial class Client_Menu
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
            this.btnlogoutclient = new System.Windows.Forms.Button();
            this.btnbillpayclient = new System.Windows.Forms.Button();
            this.btnreservationmenuclient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnoidentity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogoutclient
            // 
            this.btnlogoutclient.Location = new System.Drawing.Point(271, 72);
            this.btnlogoutclient.Name = "btnlogoutclient";
            this.btnlogoutclient.Size = new System.Drawing.Size(75, 23);
            this.btnlogoutclient.TabIndex = 36;
            this.btnlogoutclient.Text = "Logout";
            this.btnlogoutclient.UseVisualStyleBackColor = true;
            this.btnlogoutclient.Click += new System.EventHandler(this.Btnlogoutclient_Click);
            // 
            // btnbillpayclient
            // 
            this.btnbillpayclient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbillpayclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbillpayclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbillpayclient.Location = new System.Drawing.Point(12, 182);
            this.btnbillpayclient.Margin = new System.Windows.Forms.Padding(2);
            this.btnbillpayclient.Name = "btnbillpayclient";
            this.btnbillpayclient.Size = new System.Drawing.Size(334, 54);
            this.btnbillpayclient.TabIndex = 35;
            this.btnbillpayclient.Text = "Billing and Payment";
            this.btnbillpayclient.UseVisualStyleBackColor = false;
            this.btnbillpayclient.Click += new System.EventHandler(this.Btnbillpayclient_Click);
            // 
            // btnreservationmenuclient
            // 
            this.btnreservationmenuclient.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnreservationmenuclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreservationmenuclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservationmenuclient.Location = new System.Drawing.Point(12, 110);
            this.btnreservationmenuclient.Margin = new System.Windows.Forms.Padding(2);
            this.btnreservationmenuclient.Name = "btnreservationmenuclient";
            this.btnreservationmenuclient.Size = new System.Drawing.Size(334, 54);
            this.btnreservationmenuclient.TabIndex = 34;
            this.btnreservationmenuclient.Text = "Reservation";
            this.btnreservationmenuclient.UseVisualStyleBackColor = false;
            this.btnreservationmenuclient.Click += new System.EventHandler(this.Btnreservationmenuclient_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 69);
            this.label1.TabIndex = 33;
            this.label1.Text = "Client Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnoidentity
            // 
            this.lblnoidentity.AutoSize = true;
            this.lblnoidentity.Location = new System.Drawing.Point(13, 73);
            this.lblnoidentity.Name = "lblnoidentity";
            this.lblnoidentity.Size = new System.Drawing.Size(35, 13);
            this.lblnoidentity.TabIndex = 37;
            this.lblnoidentity.Text = "label2";
            // 
            // Client_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(358, 460);
            this.Controls.Add(this.lblnoidentity);
            this.Controls.Add(this.btnlogoutclient);
            this.Controls.Add(this.btnbillpayclient);
            this.Controls.Add(this.btnreservationmenuclient);
            this.Controls.Add(this.label1);
            this.Name = "Client_Menu";
            this.Text = "Client_Menu";
            this.Load += new System.EventHandler(this.Client_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogoutclient;
        private System.Windows.Forms.Button btnbillpayclient;
        private System.Windows.Forms.Button btnreservationmenuclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnoidentity;
    }
}