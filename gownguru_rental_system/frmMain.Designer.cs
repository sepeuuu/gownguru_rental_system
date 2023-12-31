﻿namespace gownguru_rental_system
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnFormerEmp = new System.Windows.Forms.Button();
            this.GownContainer = new System.Windows.Forms.Panel();
            this.btnReturned = new System.Windows.Forms.Button();
            this.btnGown = new System.Windows.Forms.Button();
            this.btnRented = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.GownTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingsTimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPOS = new System.Windows.Forms.Button();
            this.SettingsContainer = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.btnTransactionLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.GownContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SettingsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1102, 8);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(19, 21);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 16;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1138, 8);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(19, 21);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 15;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1174, 8);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(19, 21);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 14;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Black;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.Color.White;
            this.btnArchive.Location = new System.Drawing.Point(0, 124);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnArchive.Size = new System.Drawing.Size(193, 31);
            this.btnArchive.TabIndex = 14;
            this.btnArchive.Text = "Archive";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Black;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(0, 62);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(193, 31);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnFormerEmp
            // 
            this.btnFormerEmp.BackColor = System.Drawing.Color.Black;
            this.btnFormerEmp.FlatAppearance.BorderSize = 0;
            this.btnFormerEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormerEmp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormerEmp.ForeColor = System.Drawing.Color.White;
            this.btnFormerEmp.Location = new System.Drawing.Point(0, 93);
            this.btnFormerEmp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFormerEmp.Name = "btnFormerEmp";
            this.btnFormerEmp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFormerEmp.Size = new System.Drawing.Size(195, 31);
            this.btnFormerEmp.TabIndex = 12;
            this.btnFormerEmp.Text = "Former Employee";
            this.btnFormerEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormerEmp.UseVisualStyleBackColor = false;
            this.btnFormerEmp.Click += new System.EventHandler(this.btnFormerEmp_Click);
            // 
            // GownContainer
            // 
            this.GownContainer.BackColor = System.Drawing.Color.Black;
            this.GownContainer.Controls.Add(this.btnReturned);
            this.GownContainer.Controls.Add(this.btnGown);
            this.GownContainer.Controls.Add(this.btnRented);
            this.GownContainer.Controls.Add(this.btnManage);
            this.GownContainer.Location = new System.Drawing.Point(3, 144);
            this.GownContainer.MaximumSize = new System.Drawing.Size(191, 162);
            this.GownContainer.MinimumSize = new System.Drawing.Size(191, 37);
            this.GownContainer.Name = "GownContainer";
            this.GownContainer.Size = new System.Drawing.Size(191, 143);
            this.GownContainer.TabIndex = 0;
            // 
            // btnReturned
            // 
            this.btnReturned.BackColor = System.Drawing.Color.Black;
            this.btnReturned.FlatAppearance.BorderSize = 0;
            this.btnReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturned.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturned.ForeColor = System.Drawing.Color.White;
            this.btnReturned.Location = new System.Drawing.Point(-1, 106);
            this.btnReturned.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReturned.Name = "btnReturned";
            this.btnReturned.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReturned.Size = new System.Drawing.Size(192, 31);
            this.btnReturned.TabIndex = 4;
            this.btnReturned.Text = "Returned";
            this.btnReturned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturned.UseVisualStyleBackColor = false;
            this.btnReturned.Click += new System.EventHandler(this.btnReturned_Click);
            // 
            // btnGown
            // 
            this.btnGown.BackColor = System.Drawing.Color.Black;
            this.btnGown.FlatAppearance.BorderSize = 0;
            this.btnGown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGown.ForeColor = System.Drawing.Color.White;
            this.btnGown.Image = ((System.Drawing.Image)(resources.GetObject("btnGown.Image")));
            this.btnGown.Location = new System.Drawing.Point(0, 0);
            this.btnGown.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnGown.Name = "btnGown";
            this.btnGown.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGown.Size = new System.Drawing.Size(191, 36);
            this.btnGown.TabIndex = 1;
            this.btnGown.Text = "Gown                           ";
            this.btnGown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGown.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGown.UseVisualStyleBackColor = false;
            this.btnGown.Click += new System.EventHandler(this.btnGown_Click);
            // 
            // btnRented
            // 
            this.btnRented.BackColor = System.Drawing.Color.Black;
            this.btnRented.FlatAppearance.BorderSize = 0;
            this.btnRented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRented.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRented.ForeColor = System.Drawing.Color.White;
            this.btnRented.Location = new System.Drawing.Point(0, 71);
            this.btnRented.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRented.Name = "btnRented";
            this.btnRented.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRented.Size = new System.Drawing.Size(191, 31);
            this.btnRented.TabIndex = 3;
            this.btnRented.Text = "Rented";
            this.btnRented.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRented.UseVisualStyleBackColor = false;
            this.btnRented.Click += new System.EventHandler(this.btnRented_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.Black;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(0, 36);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnManage.Size = new System.Drawing.Size(191, 31);
            this.btnManage.TabIndex = 13;
            this.btnManage.Text = "Manage";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.TextChanged += new System.EventHandler(this.btnManage_TextChanged);
            this.btnManage.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Black;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(0, 31);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(191, 31);
            this.btnCategory.TabIndex = 10;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Black;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(4, 292);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(192, 31);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(4, 108);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(192, 31);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // GownTimer
            // 
            this.GownTimer.Interval = 10;
            this.GownTimer.Tick += new System.EventHandler(this.GownTimer_Tick);
            // 
            // SettingsTimer
            // 
            this.SettingsTimer.Interval = 10;
            this.SettingsTimer.Tick += new System.EventHandler(this.SettingsTimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel1.Controls.Add(this.GownContainer);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomer);
            this.flowLayoutPanel1.Controls.Add(this.btnPOS);
            this.flowLayoutPanel1.Controls.Add(this.SettingsContainer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 713);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.Black;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(4, 327);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPOS.Size = new System.Drawing.Size(192, 31);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // SettingsContainer
            // 
            this.SettingsContainer.BackColor = System.Drawing.Color.Black;
            this.SettingsContainer.Controls.Add(this.btnTransactionLog);
            this.SettingsContainer.Controls.Add(this.btnArchive);
            this.SettingsContainer.Controls.Add(this.btnSettings);
            this.SettingsContainer.Controls.Add(this.btnFormerEmp);
            this.SettingsContainer.Controls.Add(this.btnEmployee);
            this.SettingsContainer.Controls.Add(this.btnCategory);
            this.SettingsContainer.Location = new System.Drawing.Point(3, 363);
            this.SettingsContainer.MaximumSize = new System.Drawing.Size(192, 200);
            this.SettingsContainer.MinimumSize = new System.Drawing.Size(192, 35);
            this.SettingsContainer.Name = "SettingsContainer";
            this.SettingsContainer.Size = new System.Drawing.Size(192, 195);
            this.SettingsContainer.TabIndex = 18;
            this.SettingsContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsContainer_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(-3, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(195, 31);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings                        ";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.TextChanged += new System.EventHandler(this.btnSettings_TextChanged);
            this.btnSettings.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.White;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(193, 36);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1011, 713);
            this.CenterPanel.TabIndex = 4;
            // 
            // btnTransactionLog
            // 
            this.btnTransactionLog.BackColor = System.Drawing.Color.Black;
            this.btnTransactionLog.FlatAppearance.BorderSize = 0;
            this.btnTransactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionLog.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionLog.ForeColor = System.Drawing.Color.White;
            this.btnTransactionLog.Location = new System.Drawing.Point(0, 159);
            this.btnTransactionLog.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnTransactionLog.Name = "btnTransactionLog";
            this.btnTransactionLog.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransactionLog.Size = new System.Drawing.Size(193, 31);
            this.btnTransactionLog.TabIndex = 15;
            this.btnTransactionLog.Text = "Transaction Log";
            this.btnTransactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionLog.UseVisualStyleBackColor = false;
            this.btnTransactionLog.Click += new System.EventHandler(this.btnTransactionLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 749);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.GownContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SettingsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnReturned;
        private System.Windows.Forms.Button btnRented;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnGown;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnFormerEmp;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel GownContainer;
        private System.Windows.Forms.Timer GownTimer;
        private System.Windows.Forms.Timer SettingsTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel SettingsContainer;
        private System.Windows.Forms.Button btnTransactionLog;
    }
}