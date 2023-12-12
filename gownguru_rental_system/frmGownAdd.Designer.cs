namespace gownguru_rental_system
{
    partial class frmGownAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGownAdd));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.lblGid = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRprice = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDateAdded = new System.Windows.Forms.DateTimePicker();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 60);
            this.panel2.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(586, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(19, 21);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gown Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gown Name";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(183, 89);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(40, 16);
            this.txtStatus.TabIndex = 13;
            this.txtStatus.Text = "Status";
            // 
            // lblGid
            // 
            this.lblGid.AutoSize = true;
            this.lblGid.Location = new System.Drawing.Point(27, 414);
            this.lblGid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGid.Name = "lblGid";
            this.lblGid.Size = new System.Drawing.Size(49, 16);
            this.lblGid.TabIndex = 8;
            this.lblGid.Text = "gownId";
            this.lblGid.Visible = false;
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Location = new System.Drawing.Point(314, 89);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(82, 16);
            this.txtSize.TabIndex = 14;
            this.txtSize.Text = "Size Available";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(183, 144);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(58, 16);
            this.Category.TabIndex = 16;
            this.Category.Text = "Category";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(27, 144);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(71, 16);
            this.txtPrice.TabIndex = 15;
            this.txtPrice.Text = "Rental Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Condition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 107);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 21);
            this.txtName.TabIndex = 0;
            // 
            // txtRprice
            // 
            this.txtRprice.Location = new System.Drawing.Point(30, 162);
            this.txtRprice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRprice.Name = "txtRprice";
            this.txtRprice.Size = new System.Drawing.Size(138, 21);
            this.txtRprice.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cbStatus.Location = new System.Drawing.Point(186, 107);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(115, 24);
            this.cbStatus.TabIndex = 1;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "XS",
            "Small",
            "Meduim",
            "Large"});
            this.cbSize.Location = new System.Drawing.Point(317, 103);
            this.cbSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(115, 24);
            this.cbSize.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(186, 162);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(115, 24);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbCondition
            // 
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "Brand New",
            "Good",
            "Fair",
            "Poor"});
            this.cbCondition.Location = new System.Drawing.Point(317, 162);
            this.cbCondition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(115, 24);
            this.cbCondition.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(30, 270);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(542, 95);
            this.txtDesc.TabIndex = 6;
            this.txtDesc.Text = "";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(486, 220);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(74, 31);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Upload";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(498, 399);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SlateGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(340, 399);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 31);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(419, 399);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 31);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPic
            // 
            this.txtPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPic.Location = new System.Drawing.Point(465, 89);
            this.txtPic.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(107, 126);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtPic.TabIndex = 11;
            this.txtPic.TabStop = false;
            this.txtPic.Click += new System.EventHandler(this.txtPic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date Added";
            // 
            // dtDateAdded
            // 
            this.dtDateAdded.Location = new System.Drawing.Point(186, 219);
            this.dtDateAdded.Name = "dtDateAdded";
            this.dtDateAdded.Size = new System.Drawing.Size(246, 21);
            this.dtDateAdded.TabIndex = 20;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(30, 220);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(138, 21);
            this.txtColor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Color";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGownAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(606, 451);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateAdded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtRprice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblGid);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmGownAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGownAdd";
            this.Load += new System.EventHandler(this.frmGownAdd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtSize;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label lblGid;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtRprice;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.ComboBox cbSize;
        public System.Windows.Forms.ComboBox cbCategory;
        public System.Windows.Forms.ComboBox cbCondition;
        public System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.RichTextBox txtDesc;
        public System.Windows.Forms.PictureBox txtPic;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtDateAdded;
        public System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}