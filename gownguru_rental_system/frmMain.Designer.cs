namespace gownguru_rental_system
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnReturned = new System.Windows.Forms.Button();
            this.btnRented = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnGown = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnReturned);
            this.panel2.Controls.Add(this.btnRented);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnGown);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(12, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 471);
            this.panel2.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(4, 300);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(119, 31);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(4, 263);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(119, 31);
            this.btnCategory.TabIndex = 8;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(4, 437);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(119, 31);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(4, 226);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 31);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(4, 190);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(119, 31);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Manage User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReturned
            // 
            this.btnReturned.Location = new System.Drawing.Point(4, 153);
            this.btnReturned.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Size = new System.Drawing.Size(119, 31);
            this.btnReturned.TabIndex = 4;
            this.btnReturned.Text = "Returned Gowns";
            this.btnReturned.UseVisualStyleBackColor = true;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnRented
            // 
            this.btnRented.Location = new System.Drawing.Point(4, 114);
            this.btnRented.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRented.Name = "btnRented";
            this.btnRented.Size = new System.Drawing.Size(119, 31);
            this.btnRented.TabIndex = 3;
            this.btnRented.Text = "Rented Gowns";
            this.btnRented.UseVisualStyleBackColor = true;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(4, 78);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(119, 31);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnGown
            // 
            this.btnGown.Location = new System.Drawing.Point(4, 41);
            this.btnGown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGown.Name = "btnGown";
            this.btnGown.Size = new System.Drawing.Size(119, 31);
            this.btnGown.TabIndex = 1;
            this.btnGown.Text = "Gown";
            this.btnGown.UseVisualStyleBackColor = true;
            this.btnGown.Click += new System.EventHandler(this.btnGown_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(4, 4);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(119, 31);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Location = new System.Drawing.Point(144, 42);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(749, 471);
            this.CenterPanel.TabIndex = 2;
            // 
            // btnMax
            // 
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(763, 2);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 18);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(734, -2);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 18);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(792, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 526);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnReturned;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnGown;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSettings;
    }
}