namespace Hotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnregisfrmlogin = new System.Windows.Forms.Button();
            this.btnloginfrmlogin = new System.Windows.Forms.Button();
            this.tbxnoidentitylogin = new System.Windows.Forms.TextBox();
            this.tbxphonelogin = new System.Windows.Forms.TextBox();
            this.lblphonelogin = new System.Windows.Forms.Label();
            this.lblnoidentitylogin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(152, 150);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnregisfrmlogin);
            this.groupBox1.Controls.Add(this.btnloginfrmlogin);
            this.groupBox1.Controls.Add(this.tbxnoidentitylogin);
            this.groupBox1.Controls.Add(this.tbxphonelogin);
            this.groupBox1.Controls.Add(this.lblphonelogin);
            this.groupBox1.Controls.Add(this.lblnoidentitylogin);
            this.groupBox1.Location = new System.Drawing.Point(9, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(343, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnregisfrmlogin
            // 
            this.btnregisfrmlogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnregisfrmlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregisfrmlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisfrmlogin.Location = new System.Drawing.Point(2, 128);
            this.btnregisfrmlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnregisfrmlogin.Name = "btnregisfrmlogin";
            this.btnregisfrmlogin.Size = new System.Drawing.Size(170, 58);
            this.btnregisfrmlogin.TabIndex = 3;
            this.btnregisfrmlogin.Text = "REGIS";
            this.btnregisfrmlogin.UseVisualStyleBackColor = false;
            this.btnregisfrmlogin.Click += new System.EventHandler(this.Btnregisfrmlogin_Click);
            // 
            // btnloginfrmlogin
            // 
            this.btnloginfrmlogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnloginfrmlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloginfrmlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginfrmlogin.Location = new System.Drawing.Point(176, 128);
            this.btnloginfrmlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnloginfrmlogin.Name = "btnloginfrmlogin";
            this.btnloginfrmlogin.Size = new System.Drawing.Size(170, 58);
            this.btnloginfrmlogin.TabIndex = 2;
            this.btnloginfrmlogin.Text = "LOGIN";
            this.btnloginfrmlogin.UseVisualStyleBackColor = false;
            this.btnloginfrmlogin.Click += new System.EventHandler(this.Btnloginfrmlogin_Click);
            // 
            // tbxnoidentitylogin
            // 
            this.tbxnoidentitylogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnoidentitylogin.Location = new System.Drawing.Point(146, 32);
            this.tbxnoidentitylogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxnoidentitylogin.Multiline = true;
            this.tbxnoidentitylogin.Name = "tbxnoidentitylogin";
            this.tbxnoidentitylogin.Size = new System.Drawing.Size(200, 32);
            this.tbxnoidentitylogin.TabIndex = 1;
            // 
            // tbxphonelogin
            // 
            this.tbxphonelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxphonelogin.Location = new System.Drawing.Point(146, 79);
            this.tbxphonelogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxphonelogin.Multiline = true;
            this.tbxphonelogin.Name = "tbxphonelogin";
            this.tbxphonelogin.PasswordChar = '*';
            this.tbxphonelogin.Size = new System.Drawing.Size(200, 32);
            this.tbxphonelogin.TabIndex = 1;
            // 
            // lblphonelogin
            // 
            this.lblphonelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonelogin.Location = new System.Drawing.Point(4, 79);
            this.lblphonelogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphonelogin.Name = "lblphonelogin";
            this.lblphonelogin.Size = new System.Drawing.Size(138, 32);
            this.lblphonelogin.TabIndex = 0;
            this.lblphonelogin.Text = "Phone";
            this.lblphonelogin.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblnoidentitylogin
            // 
            this.lblnoidentitylogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoidentitylogin.Location = new System.Drawing.Point(4, 32);
            this.lblnoidentitylogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnoidentitylogin.Name = "lblnoidentitylogin";
            this.lblnoidentitylogin.Size = new System.Drawing.Size(138, 32);
            this.lblnoidentitylogin.TabIndex = 0;
            this.lblnoidentitylogin.Text = "No. Identity";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(361, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnloginfrmlogin;
        private System.Windows.Forms.TextBox tbxnoidentitylogin;
        private System.Windows.Forms.TextBox tbxphonelogin;
        private System.Windows.Forms.Label lblphonelogin;
        private System.Windows.Forms.Label lblnoidentitylogin;
        private System.Windows.Forms.Button btnregisfrmlogin;
    }
}